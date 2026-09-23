using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeeItemLineDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FeeItemLineDTO : AopObject
    {
        /// <summary>
        /// 金额总量 = price * quantity，单位：分，188898表示1888.98元
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 费用项名称，如"血常规检查"、"一次性采血管"
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 该项费用单价，单位：分，188898表示1888.98元
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 数量，单位：个
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 关联的商品编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }
    }
}
