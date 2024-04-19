using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimePeriod Data Structure.
    /// </summary>
    [Serializable]
    public class TimePeriod : AopObject
    {
        /// <summary>
        /// 自提时段开始时间，如05:00
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 自提时段结束时间，如23:30
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }
    }
}
