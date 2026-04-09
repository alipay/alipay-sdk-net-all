using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeserviceItemWeekPrice Data Structure.
    /// </summary>
    [Serializable]
    public class LifeserviceItemWeekPrice : AopObject
    {
        /// <summary>
        /// 周一到周日列表 分别对应"1"、"2"..."7" 可用时间范围 必填该字段
        /// </summary>
        [XmlArray("days_of_week")]
        [XmlArrayItem("string")]
        public List<string> DaysOfWeek { get; set; }

        /// <summary>
        /// 结束时间。格式：HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 当日可用还是次日可用 SAME_DAY代表开始时间和结束时间在同一天内 NEXT_DAY代表结束时间在开始时间的第二天 必填
        /// </summary>
        [XmlElement("end_time_type")]
        public string EndTimeType { get; set; }

        /// <summary>
        /// 原价。单位分
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 售价。单位分
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 开始时间。格式：HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
