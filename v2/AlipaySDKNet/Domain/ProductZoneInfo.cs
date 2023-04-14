using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductZoneInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProductZoneInfo : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 产品原价(单位：元),保留2位小数
        /// </summary>
        [XmlElement("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 区间唯一ID
        /// </summary>
        [XmlElement("out_zone_id")]
        public string OutZoneId { get; set; }

        /// <summary>
        /// 产品售卖价(单位：元),保留2位小数
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 库存,无限库存就99999，日历预订产品是1或0
        /// </summary>
        [XmlElement("stock_count")]
        public long StockCount { get; set; }

        /// <summary>
        /// 商品规格。日历型票券商品必填，其他类型商品不需要填写。
        /// </summary>
        [XmlElement("zone_name")]
        public string ZoneName { get; set; }
    }
}
