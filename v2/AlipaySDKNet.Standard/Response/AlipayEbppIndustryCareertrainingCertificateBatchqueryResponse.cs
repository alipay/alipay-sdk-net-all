using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCertificateBatchqueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingCertificateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("certificate_objects")]
        public List<CertificateObjects> List { get; set; }

        /// <summary>
        /// 总个数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
