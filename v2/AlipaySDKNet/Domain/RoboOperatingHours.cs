using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboOperatingHours Data Structure.
    /// </summary>
    [Serializable]
    public class RoboOperatingHours : AopObject
    {
        /// <summary>
        /// 每周运营星期天数
        /// </summary>
        [XmlArray("day")]
        [XmlArrayItem("string")]
        public List<string> Day { get; set; }

        /// <summary>
        /// 每天运营时间范围
        /// </summary>
        [XmlArray("time")]
        [XmlArrayItem("robo_time_slot")]
        public List<RoboTimeSlot> Time { get; set; }
    }
}
