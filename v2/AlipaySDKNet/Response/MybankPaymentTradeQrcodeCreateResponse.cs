using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeQrcodeCreateResponse.
    /// </summary>
    public class MybankPaymentTradeQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 加密的token
        /// </summary>
        [XmlElement("encrypt_token")]
        public string EncryptToken { get; set; }

        /// <summary>
        /// url地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
