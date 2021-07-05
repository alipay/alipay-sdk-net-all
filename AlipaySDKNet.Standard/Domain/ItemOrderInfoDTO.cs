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
        /// 商品名称; 使用支付宝电子小票时，必填;（is_alipay_ticket 是 "1"时，必填）
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量（单位：自拟）;使用支付宝电子小票时，必填;（is_alipay_ticket 是 "1"时，必填）
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品 sku id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品单价（单位: 元）;使用支付宝电子小票时，必填;（is_alipay_ticket 是 "1"时，必填）
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
