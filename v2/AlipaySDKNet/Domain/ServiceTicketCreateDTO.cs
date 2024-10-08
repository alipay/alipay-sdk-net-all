using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceTicketCreateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceTicketCreateDTO : AopObject
    {
        /// <summary>
        /// 事件的动作
        /// </summary>
        [XmlElement("event_action")]
        public string EventAction { get; set; }

        /// <summary>
        /// 事件内容所有字段
        /// </summary>
        [XmlElement("event_content")]
        public string EventContent { get; set; }

        /// <summary>
        /// 事件触发时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 坐席id
        /// </summary>
        [XmlElement("seat_id")]
        public string SeatId { get; set; }

        /// <summary>
        /// 坐席类型
        /// </summary>
        [XmlElement("seat_type")]
        public string SeatType { get; set; }
    }
}
