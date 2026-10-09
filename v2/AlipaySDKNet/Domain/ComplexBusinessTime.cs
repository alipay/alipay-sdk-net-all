using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComplexBusinessTime Data Structure.
    /// </summary>
    [Serializable]
    public class ComplexBusinessTime : AopObject
    {
        /// <summary>
        /// 营业时间段，支持多个时间段，例如08:00-11:00，14:00-16:00
        /// </summary>
        [XmlArray("time_period")]
        [XmlArrayItem("complex_business_time_period")]
        public List<ComplexBusinessTimePeriod> TimePeriod { get; set; }

        /// <summary>
        /// 本对象表示周几的营业时间。1~6表示周一到周六，7表示周日
        /// </summary>
        [XmlElement("week_day")]
        public long WeekDay { get; set; }
    }
}
