using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HourAppointment Data Structure.
    /// </summary>
    [Serializable]
    public class HourAppointment : AopObject
    {
        /// <summary>
        /// 结束时间 hh:mm
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 开始时间 hh:mm
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
