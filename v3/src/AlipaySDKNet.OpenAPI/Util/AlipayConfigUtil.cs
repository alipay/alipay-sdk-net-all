using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Util.Model;
using Org.BouncyCastle.X509;

namespace AlipaySDKNet.OpenAPI.Util
{
    /// <summary>
    /// alipay工具类
    /// </summary>
    public class AlipayConfigUtil
    {
        /// <summary>
        /// 网关地址
        /// </summary>
        private string serverUrl;
        
        /// <summary>
        /// 开放平台上创建的应用的ID
        /// </summary>
        private string appId;

        /// <summary>
        /// 字符串编码，推荐：UTF-8
        /// </summary>
        private string charset = "UTF-8";

        /// <summary>
        /// 商户私钥
        /// </summary>
        private string privateKeyPem;

        /// <summary>
        /// 支付宝公钥字符串（公钥模式下设置，证书模式下无需设置）
        /// </summary>
        private string alipayPublicKey;

        /// <summary>
        /// 敏感信息对称加密算法密钥
        /// </summary>
        private string encryptKey;

        /// <summary>
        /// 敏感信息对称加密算法类型，推荐：AES
        /// </summary>
        private string encryptType = "AES";

        /// <summary>
        /// 支付宝根证书序列号，用于每次调动OpenAPI时发送给网关
        /// </summary>
        private string rootCertSN;

        /// <summary>
        /// 商户证书序列号，用于每次调动OpenAPI时发送给网关
        /// </summary>
        private string appCertSN;

        /// <summary>
        /// 不同支付宝公钥证书序列号对应的公钥内容
        /// </summary>
        private readonly Dictionary<string, string> sn2PublicKey = new Dictionary<string, string>();

        private readonly Object DictionaryLock = new Object();

        private static readonly string ALIPAY_SHA_256_WITH_RSA = "ALIPAY-SHA256withRSA";

        // private static readonly string RSA = "RSA";

        /// <summary>
        /// 128位全0初始向量
        /// </summary>
        private static readonly byte[] AES_IV = InitIV(16);

        public AlipayConfigUtil()
        {
        }

        public AlipayConfigUtil(AlipayConfig alipayConfig)
        {
            serverUrl = alipayConfig.ServerUrl;
            appId = alipayConfig.AppId;
            privateKeyPem = alipayConfig.PrivateKey;
            alipayPublicKey = alipayConfig.AlipayPublicKey;
            //对称加密
            encryptType = alipayConfig.EncryptType;
            encryptKey = alipayConfig.EncryptKey;
            
            //设置了支付宝公钥证书相关参数才初始化证书模式内容
            if(string.IsNullOrEmpty(alipayConfig.AlipayPublicCertPath) && string.IsNullOrEmpty(alipayConfig.AlipayPublicCertContent)) return;
            InitCertEnvironment(alipayConfig);
        }

        public string ServerUrl
        {
            get { return serverUrl; }
            set { serverUrl = value; }
        }

        public string AppId
        {
            get { return appId; }
            set { appId = value; }
        }

        public string Charset
        {
            get { return charset; }
            set { charset = value; }
        }

        public string PrivateKeyPem
        {
            get { return privateKeyPem; }
            set { privateKeyPem = value; }
        }

        public string AlipayPublicKey
        {
            get { return alipayPublicKey; }
            set { alipayPublicKey = value; }
        }

        public string EncryptKey
        {
            get { return encryptKey; }
            set { encryptKey = value; }
        }

        public string EncryptType
        {
            get { return encryptType; }
            set { encryptType = value; }
        }

        public string RootCertSn
        {
            get { return rootCertSN; }
            set { rootCertSN = value; }
        }

        public string AppCertSn
        {
            get { return appCertSN; }
            set { appCertSN = value; }
        }

        /// <summary>
        /// 初始化证书模式的运行环境
        /// </summary>
        /// <param name="alipayConfig"></param>
        public void InitCertEnvironment(AlipayConfig alipayConfig)
        {
            //解析支付宝根证书序列号
            string rootCertContent = alipayConfig.RootCertContent;
            if (string.IsNullOrEmpty(rootCertContent))
            {
                rootCertContent = File.ReadAllText(alipayConfig.RootCertPath);
            }
            try
            {
                rootCertSN = AntCertificationUtil.GetRootCertSN(rootCertContent);
            }
            catch (Exception e)
            {
                AlipayLogger.logBizError("解析支付宝根证书序列号失败", e);
            }
            if (string.IsNullOrEmpty(rootCertSN))
            {
                throw new ApiException(400,
                    "AlipayRootCert Is Invalid，请检查支付宝根证书路径字段[RootCertPath]或根证书内容字符串字段[RootCertContent]对应的支付宝根证书是否正确");
            }

            //解析应用证书序列号
            string appCertContent = alipayConfig.AppCertContent;
            if (string.IsNullOrEmpty(appCertContent))
            {
                appCertContent = File.ReadAllText(alipayConfig.AppCertPath);
            }
            try
            {
                appCertSN = AntCertificationUtil.GetCertSN(AntCertificationUtil.ParseCert(appCertContent));
            }
            catch (Exception e)
            {
                AlipayLogger.logBizError("解析应用证书序列号失败", e);
            }
            if (string.IsNullOrEmpty(appCertSN))
            {
                throw new ApiException(400,
                    "AppCert Is Invalid，请检查应用公钥证书路径字段[AppCertPath]或应用公钥证书内容字符串字段[AppCertContent]对应的应用公钥证书是否正确");
            }

            //解析支付宝公钥证书序列号
            string alipayPublicCertContent = alipayConfig.AlipayPublicCertContent;
            if (string.IsNullOrEmpty(alipayPublicCertContent))
            {
                alipayPublicCertContent = File.ReadAllText(alipayConfig.AlipayPublicCertPath);
            }
            try
            {
                X509Certificate alipayPublicKeyCert = AntCertificationUtil.ParseCert(alipayPublicCertContent);
                string alipayPublicKeyCertSN = AntCertificationUtil.GetCertSN(alipayPublicKeyCert);
                //解析支付宝公钥
                string alipayPublicKey = AntCertificationUtil.ExtractPemPublicKeyFromCert(alipayPublicKeyCert);
                //缓存支付宝公钥证书序号对应的支付宝公钥
                AddNewAlipayPublicKey(alipayPublicKeyCertSN, alipayPublicKey);
            }
            catch (Exception e)
            {
                AlipayLogger.logBizError("解析支付宝公钥证书序列号失败", e);
                throw new ApiException(400,
                    "提取支付宝公钥证书失败，请检查支付宝公钥证书路径字段[AlipayPublicCertPath]或支付宝公钥证书内容字符串字段[AlipayPublicCertContent]对应的支付宝公钥证书是否正确");
            }
        }

        public string GetAlipayPublicKey(string sn)
        {
            //如果没有指定sn，则默认取缓存中的第一个值
            if (string.IsNullOrEmpty(sn))
            {
                lock (DictionaryLock)
                {
                    return sn2PublicKey.First().Value;
                }
            }
            lock (DictionaryLock)
            {
                if (sn2PublicKey.ContainsKey(sn))
                {
                    return sn2PublicKey[sn];
                }
                throw new ApiException(400, "支付宝公钥证书[" + sn + "]已过期，请重新下载最新支付宝公钥证书并替换原证书文件");
            }
        }
        
        public void AddNewAlipayPublicKey(String sn, String alipayPublicKey)
        {
            lock (DictionaryLock)
            {
                sn2PublicKey[sn] = alipayPublicKey;
            }
        }

        /// <summary>
        /// 计算签名（RSA2算法签名采用SHA256摘要算法）
        /// </summary>
        /// <param name="httpMethod">本次请求的http方法</param>
        /// <param name="httpRequestUri">本次请求的uri信息（不包括域名）</param>
        /// <param name="httpRequestBody">本次请求的body内容，body为空时按空字符串处理，即""</param>
        /// <param name="headerParameters">The header parameters</param>
        /// <exception cref="ApiException"></exception>
        public void Sign(string httpMethod, string httpRequestUri, string httpRequestBody, Multimap<string, string> headerParameters)
        {
            if (string.IsNullOrEmpty(privateKeyPem))
            {
                throw new ApiException(400,"私钥[PrivateKey]不可为空。");
            }
            string appAuthToken = headerParameters.TryGetValue("alipay-app-auth-token", out var list) ? list[0] : null;
            string nonce = Guid.NewGuid().ToString();
            string timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
            string authString = "app_id=" + appId 
                                          + (string.IsNullOrEmpty(appCertSN) ? "" : ",app_cert_sn=" + appCertSN)
                                          + ",nonce=" + nonce
                                          + ",timestamp=" + timestamp;
            string content = authString + "\n"
                                        + httpMethod + "\n"
                                        + httpRequestUri + "\n"
                                        + (string.IsNullOrEmpty(httpRequestBody) ? "" : httpRequestBody) + "\n"
                                        + (string.IsNullOrEmpty(appAuthToken) ? "" : appAuthToken + "\n");
            
            headerParameters.Add("Authorization", ALIPAY_SHA_256_WITH_RSA + " " + authString + ",sign=" + GenerateSign(content));
            if(!string.IsNullOrEmpty(rootCertSN))
            {
                headerParameters.Add("alipay-root-cert-sn", rootCertSN);
            }
        }

        public string GenerateSign(string content)
        {
            try
            {
                using (RSACryptoServiceProvider rsaService = BuildRSAServiceProvider(Convert.FromBase64String(privateKeyPem)))
                {
                    byte[] data = Encoding.GetEncoding(charset).GetBytes(content);
                    byte[] sign = rsaService.SignData(data, "SHA256");
                    return Convert.ToBase64String(sign);
                }
            }
            catch (Exception e)
            {
                string errorMessage = "签名遭遇异常，请检查私钥格式是否正确。content=" + content + " privateKeySize=" + privateKeyPem.Length + " reason=" + e.Message;
                // AlipayLogger.logBizError(errorMessage, e);
                throw new ApiException(400, errorMessage);
            }
        }
        
        /// <summary>
        /// 验证签名（RSA2算法签名采用SHA256摘要算法）
        /// </summary>
        /// <param name="content">待验签的内容</param>
        /// <param name="sign">签名值的Base64串</param>
        /// <param name="alipayCertSN">支付宝公钥证书序列号</param>
        /// <param name="timestamp">时间戳</param>
        /// <param name="nonce">nonce</param>
        /// <returns>true：验证成功；false：验证失败</returns>
        /// <exception cref="ApiException"></exception>
        public bool Verify(string content, string sign, string alipayCertSN, string timestamp, string nonce)
        {
            string publicKey = alipayPublicKey;
            //证书模式
            if (!string.IsNullOrEmpty(appCertSN))
            {
                publicKey = GetAlipayPublicKey(alipayCertSN);
            }
            if (string.IsNullOrEmpty(publicKey)) {
                throw new ApiException(400, "公钥不可为空");
            }
            content = timestamp + "\n"
                                + nonce + "\n"
                                + (string.IsNullOrEmpty(content) ? "" : content) + "\n";
            return GenerateVerify(content, sign, publicKey);
        }

        public bool GenerateVerify(string content, string sign, string publicKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider())
                {
                    rsaService.PersistKeyInCsp = false;
                    rsaService.ImportParameters(ConvertFromPemPublicKey(publicKey));
                    return rsaService.VerifyData(Encoding.GetEncoding(charset).GetBytes(content),
                        "SHA256", Convert.FromBase64String(sign));
                }
            }
            catch (Exception e)
            {
                string errorMessage = "验签遭遇异常，请检查公钥格式或签名是否正确。content=" + content + " sign=" + sign +
                                      " publicKey=" + publicKey + " reason=" + e.Message;
                // AlipayLogger.logBizError(errorMessage, e);
                throw new ApiException(400, errorMessage);
            }
        }

        public string DoDecrypt(string cipherTextBase64)
        {
            try
            {
                using (RSACryptoServiceProvider rsaService = BuildRSAServiceProvider(Convert.FromBase64String(privateKeyPem)))
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
            catch (Exception e)
            {
                string errorMessage = "RSA2非对称解密遭遇异常，请检查私钥格式是否正确。cipherTextBase64=" + cipherTextBase64 + " privateKeySize=" + privateKeyPem.Length + " reason=" + e.Message;
                throw new ApiException(400, errorMessage);
            }
        }

        public string DoEncrypt(string plainText)
        {
            try
            {
                using (RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider())
                {
                    rsaService.PersistKeyInCsp = false;
                    rsaService.ImportParameters(ConvertFromPemPublicKey(alipayPublicKey));
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
            catch (Exception e)
            {
                string errorMessage = "RSA2非对称解密遭遇异常，请检查公钥格式是否正确。plainText=" + plainText +
                                      " publicKey=" + alipayPublicKey + " reason=" + e.Message;
                throw new ApiException(400, errorMessage);
            }
        }
        
        private RSAParameters ConvertFromPemPublicKey(string pemPublicKey)
        {
            if (string.IsNullOrEmpty(pemPublicKey))
            {
                throw new ApiException(400,"PEM格式公钥不可为空。");
            }

            //移除干扰文本
            pemPublicKey = pemPublicKey.Replace("-----BEGIN PUBLIC KEY-----", "")
                .Replace("-----END PUBLIC KEY-----", "").Replace("\n", "").Replace("\r", "");

            byte[] keyData = Convert.FromBase64String(pemPublicKey);
            bool keySize1024 = (keyData.Length == 162);
            bool keySize2048 = (keyData.Length == 294);
            if (!(keySize1024 || keySize2048))
            {
                throw new ApiException(400,"公钥长度只支持1024和2048。");
            }
            byte[] pemModulus = (keySize1024 ? new byte[128] : new byte[256]);
            byte[] pemPublicExponent = new byte[3];
            Array.Copy(keyData, (keySize1024 ? 29 : 33), pemModulus, 0, (keySize1024 ? 128 : 256));
            Array.Copy(keyData, (keySize1024 ? 159 : 291), pemPublicExponent, 0, 3);
            RSAParameters para = new RSAParameters
            {
                Modulus = pemModulus,
                Exponent = pemPublicExponent
            };
            return para;
        }

        private RSACryptoServiceProvider BuildRSAServiceProvider(byte[] privateKey)
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

        private int GetIntegerSize(BinaryReader binaryReader)
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


        /// <summary>
        /// 是否需要加密
        /// </summary>
        /// <returns>true：需要加密。false：不需要加密</returns>
        public bool IsEncrypt()
        {
            if (string.IsNullOrEmpty(encryptKey)) return false;
            if (!"AES".Equals(encryptType))
            {
                throw new ApiException(400,
                    "当前不支持该算法类型：encryptType=" + encryptType);
            }
            return true;
        }
        
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <param name="headerParameters">The header parameters</param>
        /// <returns>密文</returns>
        public string Encrypt(string plainText, Multimap<string, string> headerParameters)
        {
            if (!IsEncrypt()) {
                return plainText;
            }
            // headerParameters.Add("alipay-encrypt-type", encryptType);
            if (string.IsNullOrEmpty(plainText))
            {
                return null;
            }
            try
            {
                byte[] keyBytes = Convert.FromBase64String(encryptKey);
                byte[] plainBytes = Encoding.GetEncoding(charset).GetBytes(plainText); ;

                RijndaelManaged rijndatel = new RijndaelManaged
                {
                    Key = keyBytes,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7,
                    IV = AES_IV
                };

                ICryptoTransform transform = rijndatel.CreateEncryptor(rijndatel.Key, rijndatel.IV);
                byte[] cipherBytes = transform.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                return Convert.ToBase64String(cipherBytes);
            }
            catch (Exception e)
            {
                throw new ApiException(400,
                    "AES加密失败，plainText=" + plainText + "，keySize=" + encryptKey.Length + "。" + e.Message);
            }
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="cipherText">密文</param>
        /// <returns>明文</returns>
        public string Decrypt(string cipherText)
        {
            if (!IsEncrypt()) {
                return cipherText;
            }
            if (string.IsNullOrEmpty(cipherText))
            {
                return null;
            }
            try
            {
                byte[] keyBytes = Convert.FromBase64String(encryptKey);
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                RijndaelManaged rijndatel = new RijndaelManaged
                {
                    Key = keyBytes,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7,
                    IV = AES_IV
                };

                ICryptoTransform transform = rijndatel.CreateDecryptor(rijndatel.Key, rijndatel.IV);
                byte[] plainBytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                return Encoding.GetEncoding(charset).GetString(plainBytes);
            }
            catch (Exception e)
            {
                throw new ApiException(400,
                    "AES解密失败，ciphertext=" + cipherText + "，keySize=" + encryptKey.Length + "。" + e.Message);
            }
        }

        private static byte[] InitIV(int blockSize)
        {
            byte[] iv = new byte[blockSize];
            for (int i = 0; i < blockSize; ++i)
            {
                iv[i] = 0x0;
            }
            return iv;
        }
    }
}