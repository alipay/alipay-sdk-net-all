using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDirectModifySku Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDirectModifySku : AopObject
    {
        /// <summary>
        /// sku原价，分为单位。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧自定义sku ID，要求 APPID 下全局唯一。和sku_id不能同时为空
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// sku售价，分为单位
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// sku售卖状态，包含以下两种状态： 已下架(DELISTING) 可售卖(AVAILABLE) 已下架: DELISTING 可售卖: AVAILABLE
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 支付宝平台侧sku ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。和out_sku_id不能同时为空。
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品sku库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
