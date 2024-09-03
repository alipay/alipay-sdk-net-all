using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class RefundItemVO : AopObject
    {
        /// <summary>
        /// 商品总金额：单位：元
        /// </summary>
        [XmlElement("amount_item")]
        public string AmountItem { get; set; }

        /// <summary>
        /// APP方商品ID
        /// </summary>
        [XmlElement("app_item_code")]
        public string AppItemCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 不包含优惠的商品原价，单位：元
        /// </summary>
        [XmlElement("price_original")]
        public string PriceOriginal { get; set; }

        /// <summary>
        /// 优惠后的商品价格，单位：元
        /// </summary>
        [XmlElement("price_sale")]
        public string PriceSale { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity_item")]
        public long QuantityItem { get; set; }

        /// <summary>
        /// 商品SKU
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
