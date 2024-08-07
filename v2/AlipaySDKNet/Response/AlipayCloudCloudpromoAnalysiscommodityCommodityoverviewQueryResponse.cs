using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysiscommodityCommodityoverviewQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysiscommodityCommodityoverviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisGoodsResult Results { get; set; }
    }
}
