using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcomItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EcomItemDTO : AopObject
    {
        /// <summary>
        /// 类目历史30天完结父订单数
        /// </summary>
        [XmlElement("cat_order_count")]
        public long CatOrderCount { get; set; }

        /// <summary>
        /// 类目历史30天完结父订单退换货率
        /// </summary>
        [XmlElement("cat_order_refund_exchange_rate")]
        public string CatOrderRefundExchangeRate { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlElement("item_detail")]
        public EcomItemExtendDetailDTO ItemDetail { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        [XmlElement("item_pict_url")]
        public string ItemPictUrl { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("item_price")]
        public long ItemPrice { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 叶子类目id
        /// </summary>
        [XmlElement("leaf_cat_id")]
        public string LeafCatId { get; set; }

        /// <summary>
        /// 叶子类目名称
        /// </summary>
        [XmlElement("leaf_cat_name")]
        public string LeafCatName { get; set; }

        /// <summary>
        /// 根类目id
        /// </summary>
        [XmlElement("root_cat_id")]
        public string RootCatId { get; set; }

        /// <summary>
        /// 根类目名称
        /// </summary>
        [XmlElement("root_cat_name")]
        public string RootCatName { get; set; }

        /// <summary>
        /// sku个数
        /// </summary>
        [XmlElement("sku_amount")]
        public string SkuAmount { get; set; }

        /// <summary>
        /// sku最大价格
        /// </summary>
        [XmlElement("sku_max_price")]
        public long SkuMaxPrice { get; set; }

        /// <summary>
        /// sku最小价格
        /// </summary>
        [XmlElement("sku_min_price")]
        public long SkuMinPrice { get; set; }
    }
}
