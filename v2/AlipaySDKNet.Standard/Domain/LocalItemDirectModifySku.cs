using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocalItemDirectModifySku Data Structure.
    /// </summary>
    [Serializable]
    public class LocalItemDirectModifySku : AopObject
    {
        /// <summary>
        /// 支持限制库存和不限库存的相互转换 当前字段已废弃(由新字段stock_limit_type代替)
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }

        /// <summary>
        /// sku原价，分为单位。（代金券对应代金券面额）
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧sku ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// sku售价，分为单位。（代金券对应代金券价格）
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// sku售卖状态，包含以下两种状态： 已下架(DELISTING) 可售卖(AVAILABLE) 已下架: DELISTING 可售卖: AVAILABLE
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 支付宝平台侧sku ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 支持限制库存和不限库存的相互转换
        /// </summary>
        [XmlElement("stock_limit_type")]
        public string StockLimitType { get; set; }

        /// <summary>
        /// 商品sku库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
