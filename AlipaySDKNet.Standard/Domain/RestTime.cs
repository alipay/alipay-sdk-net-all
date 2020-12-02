using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RestTime Data Structure.
    /// </summary>
    [Serializable]
    public class RestTime : AopObject
    {
        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 休息时间段结束时刻（hh24:mi:ss）
        /// </summary>
        [XmlElement("rest_end_time")]
        public string RestEndTime { get; set; }

        /// <summary>
        /// 休息地点，不传则由算法决定休息地点。UP：在主站休息；DOWN：在副站休息；DEPARTURE：在该线路的起点站休息
        /// </summary>
        [XmlElement("rest_spot")]
        public string RestSpot { get; set; }

        /// <summary>
        /// 休息时间段开始时刻（hh24:mi:ss）
        /// </summary>
        [XmlElement("rest_start_time")]
        public string RestStartTime { get; set; }

        /// <summary>
        /// 该时间段内的休息时长，单位：分钟
        /// </summary>
        [XmlElement("rest_time")]
        public long RestTime_ { get; set; }
    }
}
