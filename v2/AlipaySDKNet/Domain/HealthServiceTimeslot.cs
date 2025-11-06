using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthServiceTimeslot Data Structure.
    /// </summary>
    [Serializable]
    public class HealthServiceTimeslot : AopObject
    {
        /// <summary>
        /// 时间段结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 时间段开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
