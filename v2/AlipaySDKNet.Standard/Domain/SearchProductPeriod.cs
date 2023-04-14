using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchProductPeriod Data Structure.
    /// </summary>
    [Serializable]
    public class SearchProductPeriod : AopObject
    {
        /// <summary>
        /// 结束作用日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 开始作用日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 作用时间区间，e.g. HH:mm-HH:mm-标识
        /// </summary>
        [XmlArray("working_hours")]
        [XmlArrayItem("string")]
        public List<string> WorkingHours { get; set; }

        /// <summary>
        /// 作用一周的星期数
        /// </summary>
        [XmlArray("working_weekdays")]
        [XmlArrayItem("string")]
        public List<string> WorkingWeekdays { get; set; }
    }
}
