using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskSummarystatisticsQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskSummarystatisticsQueryResponse : AopResponse
    {
        /// <summary>
        /// 业绩汇总数据
        /// </summary>
        [XmlElement("summary_statistic")]
        public YunTaskSummaryStatistic SummaryStatistic { get; set; }
    }
}
