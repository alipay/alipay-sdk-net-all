using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomeServiceOutboundCreateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomeServiceOutboundCreateDTO : AopObject
    {
        /// <summary>
        /// 被叫号码，支持混淆加密
        /// </summary>
        [XmlElement("callee")]
        public string Callee { get; set; }

        /// <summary>
        /// 被叫名称
        /// </summary>
        [XmlElement("callee_name")]
        public string CalleeName { get; set; }

        /// <summary>
        /// ONLINE/HOTLINE
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 触发事件
        /// </summary>
        [XmlElement("event_action")]
        public string EventAction { get; set; }

        /// <summary>
        /// 事件内容的所有字段
        /// </summary>
        [XmlElement("event_content")]
        public string EventContent { get; set; }

        /// <summary>
        /// 事件时间
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
