using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysistrafficPageeffectivelistQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysistrafficPageeffectivelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisTrafficPageResult Results { get; set; }
    }
}
