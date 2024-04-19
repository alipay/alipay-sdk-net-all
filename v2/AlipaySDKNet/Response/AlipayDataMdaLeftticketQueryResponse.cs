using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaLeftticketQueryResponse.
    /// </summary>
    public class AlipayDataMdaLeftticketQueryResponse : AopResponse
    {
        /// <summary>
        /// 渠道售票
        /// </summary>
        [XmlElement("ticket_channel")]
        public string TicketChannel { get; set; }

        /// <summary>
        /// 城市售票
        /// </summary>
        [XmlElement("ticket_city")]
        public string TicketCity { get; set; }

        /// <summary>
        /// 项目售票
        /// </summary>
        [XmlElement("ticket_project")]
        public string TicketProject { get; set; }

        /// <summary>
        /// 票务通已售票占比
        /// </summary>
        [XmlElement("ticket_radio")]
        public long TicketRadio { get; set; }

        /// <summary>
        /// 今日售票数
        /// </summary>
        [XmlElement("today_ticket_cnt")]
        public long TodayTicketCnt { get; set; }

        /// <summary>
        /// 总售票数
        /// </summary>
        [XmlElement("total_ticket_cnt")]
        public long TotalTicketCnt { get; set; }
    }
}
