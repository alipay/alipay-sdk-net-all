using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMiniapprealtimeQueryResponse.
    /// </summary>
    public class AlipayDataMdaMiniapprealtimeQueryResponse : AopResponse
    {
        /// <summary>
        /// 月访问量
        /// </summary>
        [XmlElement("month_pv")]
        public long MonthPv { get; set; }

        /// <summary>
        /// 今日访问量
        /// </summary>
        [XmlElement("today_pv")]
        public long TodayPv { get; set; }

        /// <summary>
        /// 总访问量
        /// </summary>
        [XmlElement("total_pv")]
        public long TotalPv { get; set; }

        /// <summary>
        /// 累计用户数
        /// </summary>
        [XmlElement("uv")]
        public long Uv { get; set; }
    }
}
