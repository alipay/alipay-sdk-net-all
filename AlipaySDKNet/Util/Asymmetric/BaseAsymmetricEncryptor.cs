using System;

namespace Aop.Api.Util.Asymmetric
{
    /// <summary>
    /// 非对称加密算法
    /// </summary>
    public abstract class BaseAsymmetricEncryptor : IAsymmetricEncryptor
    {
        /// <summary>
        /// 默认字符集编码。现在都推荐使用UTF-8，之前默认是GBK，保持向下兼容性
        /// </summary>
        private static readonly string DEFAULT_CHARSET = "GBK";

        public string Decrypt(string cipherTextBase64, string charset, string privateKey)
        {
            try
            {
                ArgumentValidator.CheckNotNull(cipherTextBase64, "密文不可为Null");
                ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(privateKey), "私钥不可为空");

                if (String.IsNullOrEmpty(charset))
                {
                    charset = DEFAULT_CHARSET;
                }
                return DoDecrypt(cipherTextBase64, charset, privateKey);
            }
            catch (Exception ex)
            {
                String errorMessage = GetAsymmetricType() + "非对称解密遭遇异常，请检查私钥格式是否正确。" + ex.Message +
                    " cipherTextBase64=" + cipherTextBase64 + "，charset=" + charset + "，privateKeySize=" + privateKey.Length;
                Console.WriteLine(errorMessage);
                throw new AopException(errorMessage, ex);
            }
        }

        public string Encrypt(string plainText, string charset, string publicKey)
        {
            try
            {
                ArgumentValidator.CheckNotNull(plainText, "密文不可为Null");
                ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(publicKey), "公钥不可为空");

                if (String.IsNullOrEmpty(charset))
                {
                    charset = DEFAULT_CHARSET;
                }
                return DoEncrypt(plainText, charset, publicKey);
            }
            catch (Exception ex)
            {
                String errorMessage = GetAsymmetricType() + "非对称解密遭遇异常，请检查公钥格式是否正确。" + ex.Message +
                    " plainText=" + plainText + "，charset=" + charset + "，publicKey=" + publicKey;
                Console.WriteLine(errorMessage);
                throw new AopException(errorMessage, ex);
            }
        }

        public string Sign(string content, string charset, string privateKey)
        {
            try
            {
                ArgumentValidator.CheckNotNull(content, "待签名内容不可为Null");
                ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(privateKey), "私钥不可为空");

                if (String.IsNullOrEmpty(charset))
                {
                    charset = DEFAULT_CHARSET;
                }
                return DoSign(content, charset, privateKey);
            }
            catch (Exception ex)
            {
                String errorMessage = GetAsymmetricType() + "签名遭遇异常，请检查私钥格式是否正确。" + ex.Message +
                   " content=" + content + "，charset=" + charset + "，privateKeySize=" + privateKey.Length;
                Console.WriteLine(errorMessage);
                throw new AopException(errorMessage, ex);
            }
        }

        public bool Verify(string content, string charset, string publicKey, string sign)
        {
            try
            {
                ArgumentValidator.CheckNotNull(content, "待验签内容不可为Null");
                ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(publicKey), "公钥不可为空");
                ArgumentValidator.CheckArgument(!String.IsNullOrEmpty(sign), "签名串不可为空");

                if (String.IsNullOrEmpty(charset))
                {
                    charset = DEFAULT_CHARSET;
                }
                return DoVerify(content, charset, publicKey, sign);
            }
            catch (Exception ex)
            {
                String errorMessage = GetAsymmetricType() + "验签遭遇异常，请检查公钥格式是否正确。" + ex.Message +
                   " content=" + content + "，charset=" + charset + "，publicKey=" + publicKey + "，sign=" + sign;
                Console.WriteLine(errorMessage);
                throw new AopException(errorMessage, ex);
            }
        }

        protected abstract string DoDecrypt(string cipherTextBase64, string charset, string privateKey);

        protected abstract string DoEncrypt(string plainText, string charset, string publicKey);

        protected abstract string DoSign(string content, string charset, string privateKey);

        protected abstract bool DoVerify(string content, string charset, string publicKey, string sign);

        protected abstract string GetAsymmetricType();
    }
}