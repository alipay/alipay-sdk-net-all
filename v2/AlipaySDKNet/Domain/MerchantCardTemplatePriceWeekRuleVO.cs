using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCardTemplatePriceWeekRuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCardTemplatePriceWeekRuleVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("days_of_week")]
        [XmlArrayItem("string")]
        public List<string> DaysOfWeek { get; set; }

        /// <summary>
        /// 每天价格时段的结束时间，格式为HH:mm:ss。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 结束时间与开始时间在同一天或次日。
        /// </summary>
        [XmlElement("end_time_type")]
        public string EndTimeType { get; set; }

        /// <summary>
        /// 该时段原价，单位为分；如传入，不得小于售价。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 该时段售价，单位为分。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 每天价格时段的开始时间，格式为HH:mm:ss。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
