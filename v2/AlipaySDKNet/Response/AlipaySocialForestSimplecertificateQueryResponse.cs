using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialForestSimplecertificateQueryResponse.
    /// </summary>
    public class AlipaySocialForestSimplecertificateQueryResponse : AopResponse
    {
        /// <summary>
        /// 证书ID
        /// </summary>
        [XmlElement("cert_id")]
        public string CertId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
