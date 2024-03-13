using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskJhjtestComplexddBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityRiskJhjtestComplexddBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("out_p")]
        public string OutP { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("regress")]
        public string Regress { get; set; }
    }
}
