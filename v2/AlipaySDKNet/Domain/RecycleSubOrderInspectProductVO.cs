using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSubOrderInspectProductVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSubOrderInspectProductVO : AopObject
    {
        /// <summary>
        /// 商品的质检金额,币种：人民币，单位：元
        /// </summary>
        [XmlElement("inspect_price")]
        public string InspectPrice { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商品唯一ID
        /// </summary>
        [XmlElement("product_unique_id")]
        public string ProductUniqueId { get; set; }

        /// <summary>
        /// 商品实际定价，币种：人民币，单位：元
        /// </summary>
        [XmlElement("real_unit_pricing")]
        public string RealUnitPricing { get; set; }
    }
}
