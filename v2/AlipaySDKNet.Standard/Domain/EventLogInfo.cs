using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EventLogInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EventLogInfo : AopObject
    {
        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }
    }
}
