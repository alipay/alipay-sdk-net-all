using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysistrafficOverviewtrendQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysistrafficOverviewtrendQueryResponse : AopResponse
    {
        /// <summary>
        /// 经营分析-流量分析-流量总览趋势返回
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisTrafficResult Results { get; set; }
    }
}
