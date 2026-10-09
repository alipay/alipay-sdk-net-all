using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysistrafficSourceanalysisQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysistrafficSourceanalysisQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisTrafficSourceResult Results { get; set; }
    }
}
