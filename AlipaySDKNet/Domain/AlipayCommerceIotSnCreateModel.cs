using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotSnCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSnCreateModel : AopObject
    {
        /// <summary>
        /// 申请单描述信息
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 生成的sn数量
        /// </summary>
        [XmlElement("create_count")]
        public long CreateCount { get; set; }

        /// <summary>
        /// 硬件产品标识位 硬件差异的标识，有硬件换料的需求，需要在SN中区分
        /// </summary>
        [XmlElement("hardware_product_id")]
        public string HardwareProductId { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// pcba板厂商
        /// </summary>
        [XmlElement("pcba")]
        public string Pcba { get; set; }

        /// <summary>
        /// 产品系列
        /// </summary>
        [XmlElement("product_series")]
        public string ProductSeries { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public long RuleId { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
