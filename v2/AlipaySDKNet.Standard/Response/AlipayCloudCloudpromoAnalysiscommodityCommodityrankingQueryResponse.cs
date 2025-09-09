using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysiscommodityCommodityrankingQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysiscommodityCommodityrankingQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisGoodsRankResult Results { get; set; }
    }
}
