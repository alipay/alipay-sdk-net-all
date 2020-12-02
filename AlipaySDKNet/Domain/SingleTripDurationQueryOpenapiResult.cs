using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SingleTripDurationQueryOpenapiResult Data Structure.
    /// </summary>
    [Serializable]
    public class SingleTripDurationQueryOpenapiResult : AopObject
    {
        /// <summary>
        /// 线路方向（UP-上行，DOWN-下行）
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 结束时刻（hh24:mi:ss）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 线路ID，同一条线路的不同方向该值不同
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路Key，同一条线路的不同方向该值相同
        /// </summary>
        [XmlElement("line_key")]
        public string LineKey { get; set; }

        /// <summary>
        /// 单程行驶时间，单位：分钟
        /// </summary>
        [XmlElement("single_trip_duration")]
        public long SingleTripDuration { get; set; }

        /// <summary>
        /// 开始时刻（hh24:mi:ss）
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
