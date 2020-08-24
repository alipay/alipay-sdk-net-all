using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeInterval Data Structure.
    /// </summary>
    [Serializable]
    public class TimeInterval : AopObject
    {
        /// <summary>
        /// 时间区间结束时刻（hh24:mi:ss）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 该时间区间内最大发车间隔，单位：分钟
        /// </summary>
        [XmlElement("max_time_interval")]
        public long MaxTimeInterval { get; set; }

        /// <summary>
        /// 该时间区间内最小发车间隔，单位：分钟
        /// </summary>
        [XmlElement("min_time_interval")]
        public long MinTimeInterval { get; set; }

        /// <summary>
        /// 时间区间开始时刻（hh24:mi:ss）
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
