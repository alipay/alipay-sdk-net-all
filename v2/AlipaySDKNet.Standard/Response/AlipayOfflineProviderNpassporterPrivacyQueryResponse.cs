using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterPrivacyQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderNpassporterPrivacyQueryResponse : AopResponse
    {
        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("encrypt_cert_no_list")]
        [XmlArrayItem("string")]
        public List<string> EncryptCertNoList { get; set; }
    }
}
