using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomeServiceOutBoundUpdateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomeServiceOutBoundUpdateDTO : AopObject
    {
        /// <summary>
        /// 被叫号码
        /// </summary>
        [XmlElement("callee")]
        public string Callee { get; set; }

        /// <summary>
        /// 被叫名称
        /// </summary>
        [XmlElement("callee_name")]
        public string CalleeName { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 传递的事件
        /// </summary>
        [XmlElement("event_action")]
        public string EventAction { get; set; }

        /// <summary>
        /// 事件内容的所有字段
        /// </summary>
        [XmlElement("event_content")]
        public string EventContent { get; set; }

        /// <summary>
        /// 事件触发的时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 坐席id
        /// </summary>
        [XmlElement("seat_id")]
        public string SeatId { get; set; }

        /// <summary>
        /// 坐席类型:热线坐席，在线坐席等
        /// </summary>
        [XmlElement("seat_type")]
        public string SeatType { get; set; }
    }
}
