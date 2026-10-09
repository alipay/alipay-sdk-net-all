using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaTorchreplayuvQueryResponse.
    /// </summary>
    public class AlipayDataMdaTorchreplayuvQueryResponse : AopResponse
    {
        /// <summary>
        /// 今日用户量
        /// </summary>
        [XmlElement("today_uv")]
        public long TodayUv { get; set; }

        /// <summary>
        /// 今日用户趋势
        /// </summary>
        [XmlElement("today_uv_trend")]
        public string TodayUvTrend { get; set; }

        /// <summary>
        /// 总用户量
        /// </summary>
        [XmlElement("total_uv")]
        public long TotalUv { get; set; }
    }
}
