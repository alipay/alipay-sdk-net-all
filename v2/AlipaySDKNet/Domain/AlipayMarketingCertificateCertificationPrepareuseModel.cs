using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCertificateCertificationPrepareuseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCertificateCertificationPrepareuseModel : AopObject
    {
        /// <summary>
        /// 用户出示的核销二维码下方的12位券码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 根据用户出示的核销二维码解析出来的标识
        /// </summary>
        [XmlElement("encrypted_data")]
        public string EncryptedData { get; set; }
    }
}
