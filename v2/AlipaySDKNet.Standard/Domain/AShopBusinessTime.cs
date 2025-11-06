using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AShopBusinessTime Data Structure.
    /// </summary>
    [Serializable]
    public class AShopBusinessTime : AopObject
    {
        /// <summary>
        /// 经营日期
        /// </summary>
        [XmlArray("days")]
        [XmlArrayItem("string")]
        public List<string> Days { get; set; }

        /// <summary>
        /// 是否24小时营业
        /// </summary>
        [XmlElement("open_24_hours")]
        public bool Open24Hours { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        [XmlArray("times")]
        [XmlArrayItem("shop_time_period")]
        public List<ShopTimePeriod> Times { get; set; }
    }
}
