using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboTimeSlot Data Structure.
    /// </summary>
    [Serializable]
    public class RoboTimeSlot : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 夜间是否运营
        /// </summary>
        [XmlElement("night_operate")]
        public long NightOperate { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
