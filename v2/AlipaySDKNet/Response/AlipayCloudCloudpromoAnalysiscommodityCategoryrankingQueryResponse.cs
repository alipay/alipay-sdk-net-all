using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysiscommodityCategoryrankingQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysiscommodityCategoryrankingQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisCategoryRankResult Results { get; set; }
    }
}
