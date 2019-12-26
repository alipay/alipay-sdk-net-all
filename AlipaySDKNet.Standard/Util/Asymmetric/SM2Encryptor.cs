using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using System.Text;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Security;

namespace Aop.Api.Util.Asymmetric
{
    /// <summary>
    /// 国密SM2算法（ECC算法）加密器
    /// 签名部分采用SM3算法进行摘要计算
    /// </summary>
    public class SM2Encryptor : BaseAsymmetricEncryptor
    {
        /// <summary>
        /// SM2算法默认用户ID，目前开放平台不会使用非默认用户ID
        /// </summary>
        public const string DEFAULT_USER_ID = "1234567812345678";

        protected override string GetAsymmetricType()
        {
            return "SM2";
        }

        protected override string DoDecrypt(string cipherTextBase64, string charset, string privateKey)
        {
            //加载私钥参数
            ICipherParameters cipherParams = BuildPrivateKeyParams(privateKey).Parameters;

            //初始化SM2算法引擎
            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.Init(false, cipherParams);

            //对输入密文进行解密
            byte[] input = Convert.FromBase64String(cipherTextBase64);
            byte[] output = sm2Engine.ProcessBlock(input, 0, input.Length);

            //将解密后的明文按指定字符集编码后返回
            return Encoding.GetEncoding(charset).GetString(output);
        }

        protected override string DoEncrypt(string plainText, string charset, string publicKey)
        {
            //加载公钥参数
            ICipherParameters cipherParams = BuildPublickKeyParams(publicKey).Parameters;
            ParametersWithRandom parametersWithRandom = new ParametersWithRandom(cipherParams);

            //初始化SM2算法引擎
            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.Init(true, parametersWithRandom);

            //对输入明文进行加密
            byte[] input = Encoding.GetEncoding(charset).GetBytes(plainText);
            byte[] output = sm2Engine.ProcessBlock(input, 0, input.Length);

            //将密文Base64编码后返回
            return Convert.ToBase64String(output);
        }

        protected override string DoSign(string content, string charset, string privateKey)
        {
            //加载私钥参数
            ParametersWithID parametersWithID = BuildPrivateKeyParams(privateKey);

            //加载签名器
            SM2Signer signer = new SM2Signer();
            signer.Init(true, parametersWithID);

            //向签名器中输入原文
            byte[] input = Encoding.GetEncoding(charset).GetBytes(content);
            signer.BlockUpdate(input, 0, input.Length);

            //将签名结果转换为Base64
            return Convert.ToBase64String(signer.GenerateSignature());
        }

        protected override bool DoVerify(string content, string charset, string publicKey, string sign)
        {
            //加载公钥参数
            ParametersWithID parametersWithID = BuildPublickKeyParams(publicKey);

            //加载签名器
            SM2Signer signer = new SM2Signer();
            signer.Init(false, parametersWithID);

            //向签名器中输入原文
            byte[] input = Encoding.GetEncoding(charset).GetBytes(content);
            signer.BlockUpdate(input, 0, input.Length);

            //传入指定签名串进行验签并返回结果
            return signer.VerifySignature(Convert.FromBase64String(sign));
        }

        private ParametersWithID BuildPrivateKeyParams(string privateKey)
        {
            AsymmetricKeyParameter key = PrivateKeyFactory.CreateKey(Convert.FromBase64String(privateKey));
            ParametersWithID parametersWithID = new ParametersWithID(key, Encoding.UTF8.GetBytes(DEFAULT_USER_ID));
            return parametersWithID;
        }

        private static ParametersWithID BuildPublickKeyParams(string publicKey)
        {
            AsymmetricKeyParameter key = PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
            ParametersWithID parametersWithID = new ParametersWithID(key, Encoding.UTF8.GetBytes(DEFAULT_USER_ID));
            return parametersWithID;
        }
    }
}
