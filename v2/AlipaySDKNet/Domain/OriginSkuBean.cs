using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OriginSkuBean Data Structure.
    /// </summary>
    [Serializable]
    public class OriginSkuBean : AopObject
    {
        /// <summary>
        /// 库存对象
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
        /// 规格值，无单位概念
        /// </summary>
        [XmlElement("spec_value")]
        public string SpecValue { get; set; }
    }
}
