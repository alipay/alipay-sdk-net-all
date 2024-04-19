using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateUseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateUseInfo : AopObject
    {
        /// <summary>
        /// 三方码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 核销准备返回的支付宝平台加密券码
        /// </summary>
        [XmlElement("encrypted_code")]
        public string EncryptedCode { get; set; }

        /// <summary>
        /// 凭证核销次数。不传默认为1
        /// </summary>
        [XmlElement("use_count")]
        public long UseCount { get; set; }
    }
}
