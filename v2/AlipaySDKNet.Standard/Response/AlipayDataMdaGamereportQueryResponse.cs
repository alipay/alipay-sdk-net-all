using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaGamereportQueryResponse.
    /// </summary>
    public class AlipayDataMdaGamereportQueryResponse : AopResponse
    {
        /// <summary>
        /// 线上观赛服务次数
        /// </summary>
        [XmlElement("online_watch_cnt")]
        public long OnlineWatchCnt { get; set; }

        /// <summary>
        /// 线上观赛服务人数
        /// </summary>
        [XmlElement("online_watch_unt")]
        public long OnlineWatchUnt { get; set; }

        /// <summary>
        /// 亚运pass刷码次数
        /// </summary>
        [XmlElement("pass_cnt")]
        public long PassCnt { get; set; }

        /// <summary>
        /// 亚运pass开通人数
        /// </summary>
        [XmlElement("pass_unt")]
        public long PassUnt { get; set; }

        /// <summary>
        /// 整体售票数
        /// </summary>
        [XmlElement("ticket_cnt")]
        public long TicketCnt { get; set; }

        /// <summary>
        /// 整体售票比例
        /// </summary>
        [XmlElement("ticket_ratio")]
        public long TicketRatio { get; set; }

        /// <summary>
        /// 持票观众累计服务次数
        /// </summary>
        [XmlElement("ticket_spectator_cnt")]
        public long TicketSpectatorCnt { get; set; }

        /// <summary>
        /// 持票观众累计服务人数
        /// </summary>
        [XmlElement("ticket_spectator_unt")]
        public long TicketSpectatorUnt { get; set; }

        /// <summary>
        /// 整体累计服务次数
        /// </summary>
        [XmlElement("total_service_cnt")]
        public long TotalServiceCnt { get; set; }

        /// <summary>
        /// 整体累计服务人数
        /// </summary>
        [XmlElement("total_service_unt")]
        public long TotalServiceUnt { get; set; }
    }
}
