using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyQrcodeCreateResponse.
    /// </summary>
    public class MybankCreditLoanapplyQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成二维码的加密 token 字符串
        /// </summary>
        [XmlElement("encrypt_token")]
        public string EncryptToken { get; set; }

        /// <summary>
        /// 生成的二维码的链接地址，拿这个地址生成二维码
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
