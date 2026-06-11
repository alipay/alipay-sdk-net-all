using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvSkuItem Data Structure.
    /// </summary>
    [Serializable]
    public class IsvSkuItem : AopObject
    {
        /// <summary>
        /// 报价过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 保障期限（单位：年）
        /// </summary>
        [XmlElement("guarantee_duration")]
        public long GuaranteeDuration { get; set; }

        /// <summary>
        /// 保障公里数（单位：公里）
        /// </summary>
        [XmlElement("guarantee_mileage")]
        public long GuaranteeMileage { get; set; }

        /// <summary>
        /// 划线价（单位：元）
        /// </summary>
        [XmlElement("marked_price")]
        public string MarkedPrice { get; set; }

        /// <summary>
        /// 服务商报价ID
        /// </summary>
        [XmlElement("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// 报价时间
        /// </summary>
        [XmlElement("quote_time")]
        public string QuoteTime { get; set; }

        /// <summary>
        /// 售价（单位：元）
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 服务商SKU标识
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
