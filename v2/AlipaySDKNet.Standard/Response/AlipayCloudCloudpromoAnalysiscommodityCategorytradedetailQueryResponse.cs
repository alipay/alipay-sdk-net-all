using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysiscommodityCategorytradedetailQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysiscommodityCategorytradedetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisCategoryDetailResult Results { get; set; }
    }
}
