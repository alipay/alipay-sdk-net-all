using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysistrafficSourcetrendQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysistrafficSourcetrendQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisTrafficSourceResult Results { get; set; }
    }
}
