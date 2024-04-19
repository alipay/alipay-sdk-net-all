using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMiniappserverQueryResponse.
    /// </summary>
    public class AlipayDataMdaMiniappserverQueryResponse : AopResponse
    {
        /// <summary>
        /// 平均恢复耗时(分钟)
        /// </summary>
        [XmlElement("average_recovery_cost_mins")]
        public long AverageRecoveryCostMins { get; set; }

        /// <summary>
        /// 访问成功率
        /// </summary>
        [XmlElement("success_rate")]
        public string SuccessRate { get; set; }

        /// <summary>
        /// 今日告警次数
        /// </summary>
        [XmlElement("today_alarm_number")]
        public long TodayAlarmNumber { get; set; }

        /// <summary>
        /// 今日告警响应率
        /// </summary>
        [XmlElement("today_alarm_response_rate")]
        public string TodayAlarmResponseRate { get; set; }
    }
}
