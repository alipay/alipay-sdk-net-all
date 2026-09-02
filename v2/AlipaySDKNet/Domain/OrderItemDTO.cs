using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderItemDTO : AopObject
    {
        /// <summary>
        /// 小计金额（单位：元，必须为两位小数点的正数，建议 unit_price x quantity，如 99.90）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商品ID（家空间商品ID）
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品图片URL，如果不穿则先与接口开发者沟通
        /// </summary>
        [XmlElement("item_image")]
        public string ItemImage { get; set; }

        /// <summary>
        /// 商品名称， 无商品名称可将SKU名称传入
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 购买数量,（单位：件)
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// SKU ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// SKU名称, 无SKU名称可将商品名称传入
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// 商品单价（单位：元，必须为两位小数点的正数，如 49.95）
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
