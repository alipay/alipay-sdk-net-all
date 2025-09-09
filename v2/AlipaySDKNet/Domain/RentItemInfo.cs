using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentItemInfo : AopObject
    {
        /// <summary>
        /// 订单中的商品的下单数量
        /// </summary>
        [XmlElement("item_cnt")]
        public long ItemCnt { get; set; }

        /// <summary>
        /// 商品库商品唯一ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商户商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户商品sku_id
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 生成订单时商品的实际价格，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("real_sale_price")]
        public string RealSalePrice { get; set; }

        /// <summary>
        /// 订单时商品的售卖价，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 支付宝侧商品skuid
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
