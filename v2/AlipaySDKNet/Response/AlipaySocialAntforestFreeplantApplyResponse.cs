using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestFreeplantApplyResponse.
    /// </summary>
    public class AlipaySocialAntforestFreeplantApplyResponse : AopResponse
    {
        /// <summary>
        /// 证书ID
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }
    }
}
