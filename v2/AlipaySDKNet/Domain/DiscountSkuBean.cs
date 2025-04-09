using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountSkuBean Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountSkuBean : AopObject
    {
        /// <summary>
        /// 活动对象
        /// </summary>
        [XmlElement("activity")]
        public DiscountActivityBean Activity { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("inventory")]
        public InventoryBean Inventory { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 价格，单位：元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量，单位：个/份
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品sku
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 规格值，非可度量参数
        /// </summary>
        [XmlElement("spec_value")]
        public string SpecValue { get; set; }
    }
}
