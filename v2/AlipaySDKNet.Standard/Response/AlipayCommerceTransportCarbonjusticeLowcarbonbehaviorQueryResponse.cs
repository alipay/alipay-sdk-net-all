using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportCarbonjusticeLowcarbonbehaviorQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportCarbonjusticeLowcarbonbehaviorQueryResponse : AopResponse
    {
        /// <summary>
        /// 碳权益查询结果列表
        /// </summary>
        [XmlArray("carbon_justice_model_list")]
        [XmlArrayItem("carbon_justice_query_openapi_d_t_o")]
        public List<CarbonJusticeQueryOpenapiDTO> CarbonJusticeModelList { get; set; }
    }
}
