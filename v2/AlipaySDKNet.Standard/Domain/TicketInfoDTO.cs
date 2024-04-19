using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TicketInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TicketInfoDTO : AopObject
    {
        /// <summary>
        /// 演出地点所属的城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 场次结束时间
        /// </summary>
        [XmlElement("event_end_time")]
        public string EventEndTime { get; set; }

        /// <summary>
        /// 场次唯一标识
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 场次名称
        /// </summary>
        [XmlElement("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// 场次开始时间
        /// </summary>
        [XmlElement("event_start_time")]
        public string EventStartTime { get; set; }

        /// <summary>
        /// 演出位置
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 演出座位号
        /// </summary>
        [XmlElement("performance_seats")]
        public string PerformanceSeats { get; set; }

        /// <summary>
        /// 票编码ID，票的唯一标识
        /// </summary>
        [XmlElement("ticket_id")]
        public string TicketId { get; set; }

        /// <summary>
        /// 票据链接，跳转到票核销链接的地址
        /// </summary>
        [XmlElement("ticket_link")]
        public string TicketLink { get; set; }

        /// <summary>
        /// 票类型
        /// </summary>
        [XmlElement("ticket_type")]
        public string TicketType { get; set; }
    }
}
