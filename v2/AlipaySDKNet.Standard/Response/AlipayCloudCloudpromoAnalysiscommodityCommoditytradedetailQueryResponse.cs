using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysiscommodityCommoditytradedetailQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAnalysiscommodityCommoditytradedetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("results")]
        public OpenApiOperationalAnalysisGoodsDetailResult Results { get; set; }
    }
}
