using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskJhjtestComplexddBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskJhjtestComplexddBatchqueryModel : AopObject
    {
        /// <summary>
        /// 1111
        /// </summary>
        [XmlElement("comple_a")]
        public JhjTestNew CompleA { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("regress")]
        public string Regress { get; set; }
    }
}
