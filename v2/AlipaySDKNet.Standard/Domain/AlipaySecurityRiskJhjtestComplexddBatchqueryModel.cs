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
        /// 修改文档
        /// </summary>
        [XmlElement("comple_a")]
        public JhjTestNew CompleA { get; set; }

        /// <summary>
        /// 修改文档
        /// </summary>
        [XmlElement("regress")]
        public string Regress { get; set; }
    }
}
