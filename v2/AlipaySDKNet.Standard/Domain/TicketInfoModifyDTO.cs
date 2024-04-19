using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TicketInfoModifyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TicketInfoModifyDTO : AopObject
    {
        /// <summary>
        /// 需要更新的场次结束时间
        /// </summary>
        [XmlElement("event_end_time")]
        public string EventEndTime { get; set; }

        /// <summary>
        /// 场次ID，场次唯一标识
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 需要更新的场次开始时间
        /// </summary>
        [XmlElement("event_start_time")]
        public string EventStartTime { get; set; }

        /// <summary>
        /// 需要更新的演出场次状态
        /// </summary>
        [XmlElement("event_status")]
        public string EventStatus { get; set; }

        /// <summary>
        /// 需要更新的演出座位号
        /// </summary>
        [XmlElement("performance_seats")]
        public string PerformanceSeats { get; set; }

        /// <summary>
        /// 票编码ID，票的唯一标识
        /// </summary>
        [XmlElement("ticket_id")]
        public string TicketId { get; set; }

        /// <summary>
        /// 需要更新的票据链接，跳转到票核销链接的地址
        /// </summary>
        [XmlElement("ticket_link")]
        public string TicketLink { get; set; }

        /// <summary>
        /// 需要更新的票状态
        /// </summary>
        [XmlElement("ticket_status")]
        public string TicketStatus { get; set; }
    }
}
