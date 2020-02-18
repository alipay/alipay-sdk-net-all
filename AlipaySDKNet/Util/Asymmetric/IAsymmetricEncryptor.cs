using System;

namespace Aop.Api.Util.Asymmetric
{
    /// <summary>
    /// 非对称加密算法接口
    /// </summary>
    public interface IAsymmetricEncryptor
    {
        /// <summary>
        /// 计算指定内容的签名
        /// </summary>
        /// <param name="content">待签名的原文</param>
        /// <param name="charset">待签名的原文的字符集编码</param>
        /// <param name="privateKey">私钥字符串</param>
        /// <returns>签名字符串</returns>
        string Sign(string content, string charset, string privateKey);

        /// <summary>
        /// 验证指定内容的签名是否正确
        /// </summary>
        /// <param name="content">待校验的原文</param>
        /// <param name="charset">待校验的原文的字符集编码</param>
        /// <param name="publicKey">公钥字符串</param>
        /// <param name="sign">签名字符串</param>
        /// <returns>true：验证通过；false：验证不通过</returns>
        bool Verify(string content, string charset, string publicKey, string sign);

        /// <summary>
        /// 对明文进行非对称加密
        /// </summary>
        /// <param name="plainText">明文字符串</param>
        /// <param name="charset">明文的字符集编码</param>
        /// <param name="publicKey">公钥字符串</param>
        /// <returns>密文的Base64编码字符串</returns>
        string Encrypt(string plainText, string charset, string publicKey);

        /// <summary>
        /// 对密文进行非对称解密
        /// </summary>
        /// <param name="cipherTextBase64">密文Base64编码字符串</param>
        /// <param name="charset">明文的字符集编码</param>
        /// <param name="privateKey">私钥字符串</param>
        /// <returns>明文</returns>
        string Decrypt(string cipherTextBase64, string charset, string privateKey);
    }
}
