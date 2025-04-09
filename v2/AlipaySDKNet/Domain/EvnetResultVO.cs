using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EvnetResultVO Data Structure.
    /// </summary>
    [Serializable]
    public class EvnetResultVO : AopObject
    {
        /// <summary>
        /// 事件回溯,按照回溯内容事件升序排序
        /// </summary>
        [XmlElement("backtrackings")]
        public EventBacktrackingVO Backtrackings { get; set; }

        /// <summary>
        /// 事件发生时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 事件类型 1. 消控室离岗识别: FMC_ABSENCE_DETECTION 2. 消控室睡岗识别: FMC_SLEEP_DETECTION 3. 消防通道占用识别: FIRE_LANE_OCCUPANCY_DETECTION
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 事件id
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 事件备注
        /// </summary>
        [XmlElement("remarks")]
        public string Remarks { get; set; }
    }
}
