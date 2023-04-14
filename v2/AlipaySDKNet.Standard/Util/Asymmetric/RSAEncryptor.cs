using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Aop.Api.Util.Asymmetric
{
    /// <summary>
    /// RSA算法加密器
    /// 签名部分采用SHA1算法进行摘要计算
    /// </summary>
    public class RSAEncryptor : BaseAsymmetricEncryptor
    {
        /// <summary>
        /// RSA算法签名采用SHA1摘要算法
        /// </summary>
        /// <returns>摘要算法名称</returns>
        protected virtual string GetShaType()
        {
            return "SHA1";
        }

        protected override string GetAsymmetricType()
        {
            return "RSA";
        }

        protected override string DoDecrypt(string cipherTextBase64, string charset, string privateKey)
        {
            using (RSACryptoServiceProvider rsaService = BuildRSAServiceProvider(Convert.FromBase64String(privateKey)))
            {
                byte[] data = Convert.FromBase64String(cipherTextBase64);

                //解密块最大长度
                int maxBlockSize = rsaService.KeySize / 8;

                //如果密文长度小于等于单个解密块最大长度，直接单次调用解密接口完成解密
                if (data.Length <= maxBlockSize)
                {
                    byte[] cipherbytes = rsaService.Decrypt(data, false);
                    return Encoding.GetEncoding(charset).GetString(cipherbytes);
                }

                //如果密文长度大于单个解密块最大长度，在内存中循环调用解密接口完成解密
                using (MemoryStream plainStream = new MemoryStream())
                {
                    using (MemoryStream cipherStream = new MemoryStream(data))
                    {
                        Byte[] buffer = new Byte[maxBlockSize];
                        int readSize = cipherStream.Read(buffer, 0, maxBlockSize);
                        while (readSize > 0)
                        {
                            Byte[] cipherBlock = new Byte[readSize];
                            Array.Copy(buffer, 0, cipherBlock, 0, readSize);
                            Byte[] plainBlock = rsaService.Decrypt(cipherBlock, false);
                            plainStream.Write(plainBlock, 0, plainBlock.Length);
                            readSize = cipherStream.Read(buffer, 0, maxBlockSize);
                        }
                    }
                    return Encoding.GetEncoding(charset).GetString(plainStream.ToArray());
                }

            }
        }

        protected override string DoEncrypt(string plainText, string charset, string publicKey)
        {
            using (RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider())
            {
                rsaService.PersistKeyInCsp = false;
                rsaService.ImportParameters(ConvertFromPemPublicKey(publicKey));
                byte[] data = Encoding.GetEncoding(charset).GetBytes(plainText);

                //加密块最大长度
                int maxBlockSize = rsaService.KeySize / 8 - 11;

                //如果明文长度小于等于单个加密块最大长度，直接单次调用加密接口完成加密
                if (data.Length <= maxBlockSize)
                {
                    byte[] cipherbytes = rsaService.Encrypt(data, false);
                    return Convert.ToBase64String(cipherbytes);
                }

                //如果明文长度大于单个加密块最大长度，在内存中循环调用加密接口完成加密
                using (MemoryStream cipherStream = new MemoryStream())
                {
                    using (MemoryStream plainStream = new MemoryStream(data))
                    {
                        Byte[] buffer = new Byte[maxBlockSize];
                        int readSize = plainStream.Read(buffer, 0, maxBlockSize);
                        while (readSize > 0)
                        {
                            Byte[] plainBlock = new Byte[readSize];
                            Array.Copy(buffer, 0, plainBlock, 0, readSize);
                            Byte[] cipherBlock = rsaService.Encrypt(plainBlock, false);
                            cipherStream.Write(cipherBlock, 0, cipherBlock.Length);
                            readSize = plainStream.Read(buffer, 0, maxBlockSize);
                        }
                    }
                    return Convert.ToBase64String(cipherStream.ToArray(), Base64FormattingOptions.None);
                }
            }
        }

        protected override string DoSign(string content, string charset, string privateKey)
        {
            using (RSACryptoServiceProvider rsaService = BuildRSAServiceProvider(Convert.FromBase64String(privateKey)))
            {
                byte[] data = Encoding.GetEncoding(charset).GetBytes(content);

                byte[] sign = rsaService.SignData(data, GetShaType());
                return Convert.ToBase64String(sign);
            }
        }

        protected override bool DoVerify(string content, string charset, string publicKey, string sign)
        {
            using (RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider())
            {
                rsaService.PersistKeyInCsp = false;
                rsaService.ImportParameters(ConvertFromPemPublicKey(publicKey));

                return rsaService.VerifyData(Encoding.GetEncoding(charset).GetBytes(content),
                    GetShaType(), Convert.FromBase64String(sign));
            }
        }

        private RSAParameters ConvertFromPemPublicKey(string pemPublickKey)
        {
            if (string.IsNullOrEmpty(pemPublickKey))
            {
                throw new AopException("PEM格式公钥不可为空。");
            }

            //移除干扰文本
            pemPublickKey = pemPublickKey.Replace("-----BEGIN PUBLIC KEY-----", "")
                .Replace("-----END PUBLIC KEY-----", "").Replace("\n", "").Replace("\r", "");

            byte[] keyData = Convert.FromBase64String(pemPublickKey);
            bool keySize1024 = (keyData.Length == 162);
            bool keySize2048 = (keyData.Length == 294);
            if (!(keySize1024 || keySize2048))
            {
                throw new AopException("公钥长度只支持1024和2048。");
            }
            byte[] pemModulus = (keySize1024 ? new byte[128] : new byte[256]);
            byte[] pemPublicExponent = new byte[3];
            Array.Copy(keyData, (keySize1024 ? 29 : 33), pemModulus, 0, (keySize1024 ? 128 : 256));
            Array.Copy(keyData, (keySize1024 ? 159 : 291), pemPublicExponent, 0, 3);
            RSAParameters para = new RSAParameters();
            para.Modulus = pemModulus;
            para.Exponent = pemPublicExponent;
            return para;
        }

        private static RSACryptoServiceProvider BuildRSAServiceProvider(byte[] privateKey)
        {
            byte[] MODULUS, E, D, P, Q, DP, DQ, IQ;
            byte bt = 0;
            ushort twobytes = 0;
            int elems = 0;

            //set up stream to decode the asn.1 encoded RSA private key
            //wrap Memory Stream with BinaryReader for easy reading
            using (BinaryReader binaryReader = new BinaryReader(new MemoryStream(privateKey)))
            {
                twobytes = binaryReader.ReadUInt16();
                //data read as little endian order (actual data order for Sequence is 30 81)
                if (twobytes == 0x8130)
                {
                    //advance 1 byte
                    binaryReader.ReadByte();
                }
                else if (twobytes == 0x8230)
                {
                    //advance 2 bytes
                    binaryReader.ReadInt16();
                }
                else
                {
                    return null;
                }

                twobytes = binaryReader.ReadUInt16();
                //version number
                if (twobytes != 0x0102)
                {
                    return null;
                }
                bt = binaryReader.ReadByte();
                if (bt != 0x00)
                {
                    return null;
                }

                //all private key components are Integer sequences
                elems = GetIntegerSize(binaryReader);
                MODULUS = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                E = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                D = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                P = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                Q = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                DP = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                DQ = binaryReader.ReadBytes(elems);

                elems = GetIntegerSize(binaryReader);
                IQ = binaryReader.ReadBytes(elems);

                //create RSACryptoServiceProvider instance and initialize with public key
                RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider();
                RSAParameters rsaParams = new RSAParameters
                {
                    Modulus = MODULUS,
                    Exponent = E,
                    D = D,
                    P = P,
                    Q = Q,
                    DP = DP,
                    DQ = DQ,
                    InverseQ = IQ
                };
                rsaService.ImportParameters(rsaParams);
                return rsaService;
            }
        }

        private static int GetIntegerSize(BinaryReader binaryReader)
        {
            byte bt = 0;
            byte lowbyte = 0x00;
            byte highbyte = 0x00;
            int count = 0;

            bt = binaryReader.ReadByte();

            //expect integer
            if (bt != 0x02)
            {
                return 0;
            }
            bt = binaryReader.ReadByte();

            if (bt == 0x81)
            {
                //data size in next byte
                count = binaryReader.ReadByte();
            }
            else if (bt == 0x82)
            {
                //data size in next 2 bytes
                highbyte = binaryReader.ReadByte();
                lowbyte = binaryReader.ReadByte();
                byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };
                count = BitConverter.ToInt32(modint, 0);
            }
            else
            {
                //we already have the data size
                count = bt;
            }
            while (binaryReader.ReadByte() == 0x00)
            {   //remove high order zeros in data
                count -= 1;
            }
            //last ReadByte wasn't a removed zero, so back up a byte
            binaryReader.BaseStream.Seek(-1, SeekOrigin.Current);
            return count;
        }
    }
}
