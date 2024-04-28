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
        /// 修改文档
        /// </summary>
        [XmlElement("out_p")]
        public string OutP { get; set; }

        /// <summary>
        /// 修改文档
        /// </summary>
        [XmlElement("regress")]
        public string Regress { get; set; }
    }
}
