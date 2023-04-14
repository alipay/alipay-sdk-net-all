using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessHoursDesc Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessHoursDesc : AopObject
    {
        /// <summary>
        /// 一周中的哪几天
        /// </summary>
        [XmlArray("days_in_week")]
        [XmlArrayItem("number")]
        public List<long> DaysInWeek { get; set; }

        /// <summary>
        /// 一天中的时间，24小时制
        /// </summary>
        [XmlElement("hours")]
        public string Hours { get; set; }
    }
}
