using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityServiceQueryResponse.
    /// </summary>
    public class AlipayEbppCommunityServiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务查询列表
        /// </summary>
        [XmlArray("service_info_list")]
        [XmlArrayItem("community_service_info")]
        public List<CommunityServiceInfo> ServiceInfoList { get; set; }
    }
}
