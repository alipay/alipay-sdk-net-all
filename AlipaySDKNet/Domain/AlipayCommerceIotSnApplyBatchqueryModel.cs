using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotSnApplyBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSnApplyBatchqueryModel : AopObject
    {
        /// <summary>
        /// 每页数量，最多100
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 分页搜索偏移值
        /// </summary>
        [XmlElement("offset")]
        public long Offset { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
