using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeRangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TimeRangeInfo : AopObject
    {
        /// <summary>
        /// 开始时间  格式：HH:mm:ss
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 结束时间，可设置当日或次日结束，例如：22:00~次日07:00
        /// </summary>
        [XmlElement("end_time_info")]
        public EndTimeInfo EndTimeInfo { get; set; }
    }
}
