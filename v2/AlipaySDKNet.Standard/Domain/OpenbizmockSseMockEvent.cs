using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenbizmockSseMockEvent Data Structure.
    /// </summary>
    [Serializable]
    public class OpenbizmockSseMockEvent : AopObject
    {
        /// <summary>
        /// sse注释
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// event
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }

        /// <summary>
        /// event id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 当前事件重复次数
        /// </summary>
        [XmlElement("repeat_count")]
        public long RepeatCount { get; set; }

        /// <summary>
        /// 发送事件发送等待时间，单位为毫秒
        /// </summary>
        [XmlElement("wait_time")]
        public long WaitTime { get; set; }
    }
}
