using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncAggregationDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncAggregationDetailQueryModel : AopObject
    {
        /// <summary>
        /// 采购系统PO单?
        /// </summary>
        [XmlElement("po_no")]
        public string PoNo { get; set; }
    }
}
