using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemOrderInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderInfoDTO : AopObject
    {
        /// <summary>
        /// 商品条形码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 商品 id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量（单位：自拟）
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品数量（精度: 小数点后三位），使用商品功能时必填
        /// </summary>
        [XmlElement("quantity_dec")]
        public string QuantityDec { get; set; }

        /// <summary>
        /// 商品 sku id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品销售总价（精度: 小数点后两位，单位：元），使用商品功能必填
        /// </summary>
        [XmlElement("sku_total_price")]
        public string SkuTotalPrice { get; set; }

        /// <summary>
        /// 商品单价（单位: 元）
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
