using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceTicketUpdateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceTicketUpdateDTO : AopObject
    {
        /// <summary>
        /// 事件时间 当前字段已废弃(该字段已经被废弃，不再需要)
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("event_action")]
        public string EventAction { get; set; }

        /// <summary>
        /// 收单关联更新事件内容
        /// </summary>
        [XmlElement("event_content")]
        public string EventContent { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }
    }
}
