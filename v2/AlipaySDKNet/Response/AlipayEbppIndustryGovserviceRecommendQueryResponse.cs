using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryGovserviceRecommendQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryGovserviceRecommendQueryResponse : AopResponse
    {
        /// <summary>
        /// 根据用户意图推荐的服务
        /// </summary>
        [XmlArray("recommend_service")]
        [XmlArrayItem("service_detail_info")]
        public List<ServiceDetailInfo> RecommendService { get; set; }
    }
}
