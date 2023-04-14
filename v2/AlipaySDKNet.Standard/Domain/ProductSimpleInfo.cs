using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductSimpleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProductSimpleInfo : AopObject
    {
        /// <summary>
        /// 商品规格名称。可以是场地名称（比如羽毛球场地1）。当产品类型为日历型或者日历型票券时必填。
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 商品购买数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 商品使用结束时间（Date类型），结束时间非空时必须有开始时间传值，且开始时间必须早于结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 商品类型，'calendar'-日历型，'ticket'-票券，'course'-课程，'calendar_ticket'-日历型票券
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 产品售卖价(单位：元),保留2位小数
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 商品使用开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 产品规格信息，仅日历型票券商品需要配置该字段
        /// </summary>
        [XmlElement("zone_name")]
        public string ZoneName { get; set; }
    }
}
