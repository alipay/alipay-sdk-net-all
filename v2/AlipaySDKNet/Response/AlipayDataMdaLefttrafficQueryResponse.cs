using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaLefttrafficQueryResponse.
    /// </summary>
    public class AlipayDataMdaLefttrafficQueryResponse : AopResponse
    {
        /// <summary>
        /// 今日持证出行人次
        /// </summary>
        [XmlElement("today_certificate_traffic_cnt")]
        public long TodayCertificateTrafficCnt { get; set; }

        /// <summary>
        /// 累计持证出行人数
        /// </summary>
        [XmlElement("total_certificate_traffic_unt")]
        public long TotalCertificateTrafficUnt { get; set; }

        /// <summary>
        /// 累计持票出行人数
        /// </summary>
        [XmlElement("total_ticket_traffic_unt")]
        public long TotalTicketTrafficUnt { get; set; }

        /// <summary>
        /// 今日持票出行次数
        /// </summary>
        [XmlElement("totay_ticket_traffic_cnt")]
        public long TotayTicketTrafficCnt { get; set; }

        /// <summary>
        /// 近7日出行趋势
        /// </summary>
        [XmlElement("traffic_day_trend")]
        public string TrafficDayTrend { get; set; }

        /// <summary>
        /// 分时出行分布
        /// </summary>
        [XmlElement("traffic_hour_distribute")]
        public string TrafficHourDistribute { get; set; }

        /// <summary>
        /// 出行工具
        /// </summary>
        [XmlElement("traffic_paas")]
        public string TrafficPaas { get; set; }
    }
}
