using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkPatternDetail Data Structure.
    /// </summary>
    [Serializable]
    public class WorkPatternDetail : AopObject
    {
        /// <summary>
        /// 结束时刻（hh24:mi:ss）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 营运车次数
        /// </summary>
        [XmlElement("service_trip_count")]
        public long ServiceTripCount { get; set; }

        /// <summary>
        /// 开始时刻（hh24:mi:ss）
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
