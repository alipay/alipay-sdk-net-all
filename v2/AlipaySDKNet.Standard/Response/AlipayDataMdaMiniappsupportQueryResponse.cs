using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMiniappsupportQueryResponse.
    /// </summary>
    public class AlipayDataMdaMiniappsupportQueryResponse : AopResponse
    {
        /// <summary>
        /// 智能服务日环比
        /// </summary>
        [XmlElement("ai_service_ratio")]
        public string AiServiceRatio { get; set; }

        /// <summary>
        /// 客户满意度
        /// </summary>
        [XmlElement("customer_satisfaction")]
        public string CustomerSatisfaction { get; set; }

        /// <summary>
        /// 人工服务日环比
        /// </summary>
        [XmlElement("manual_service_ratio")]
        public string ManualServiceRatio { get; set; }

        /// <summary>
        /// 今日智能服务总量
        /// </summary>
        [XmlElement("today_ai_service_cnt")]
        public long TodayAiServiceCnt { get; set; }

        /// <summary>
        /// 今日人工服务总量
        /// </summary>
        [XmlElement("today_manual_service_cnt")]
        public long TodayManualServiceCnt { get; set; }

        /// <summary>
        /// 今日人工、智能服务量趋势
        /// </summary>
        [XmlElement("today_service_trend")]
        public string TodayServiceTrend { get; set; }

        /// <summary>
        /// 智能服务总量
        /// </summary>
        [XmlElement("total_ai_service_cnt")]
        public long TotalAiServiceCnt { get; set; }

        /// <summary>
        /// 人工服务总量
        /// </summary>
        [XmlElement("total_manual_service_cnt")]
        public long TotalManualServiceCnt { get; set; }

        /// <summary>
        /// 词云
        /// </summary>
        [XmlElement("word_cloud")]
        public string WordCloud { get; set; }

        /// <summary>
        /// 昨日智能服务总量
        /// </summary>
        [XmlElement("yesterday_ai_service_cnt")]
        public long YesterdayAiServiceCnt { get; set; }

        /// <summary>
        /// 昨日人工服务总量
        /// </summary>
        [XmlElement("yesterday_manual_service_cnt")]
        public long YesterdayManualServiceCnt { get; set; }

        /// <summary>
        /// 昨日人工、智能服务量趋势
        /// </summary>
        [XmlElement("yesterday_service_trend")]
        public string YesterdayServiceTrend { get; set; }
    }
}
