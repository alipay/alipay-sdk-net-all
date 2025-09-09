using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryGovserviceSearchRecommendResponse.
    /// </summary>
    public class AlipayEbppIndustryGovserviceSearchRecommendResponse : AopResponse
    {
        /// <summary>
        /// 搜到的服务列表
        /// </summary>
        [XmlArray("search_service_list")]
        [XmlArrayItem("service_search_detail_info")]
        public List<ServiceSearchDetailInfo> SearchServiceList { get; set; }
    }
}
