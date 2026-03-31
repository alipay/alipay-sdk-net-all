using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterFaceVerifyResponse.
    /// </summary>
    public class AlipayOfflineProviderNpassporterFaceVerifyResponse : AopResponse
    {
        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 加密证件号
        /// </summary>
        [XmlElement("encrypt_cert_no")]
        public string EncryptCertNo { get; set; }
    }
}
