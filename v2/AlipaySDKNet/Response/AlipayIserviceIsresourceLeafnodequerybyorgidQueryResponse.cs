using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceLeafnodequerybyorgidQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceLeafnodequerybyorgidQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的组织节点列表
        /// </summary>
        [XmlArray("biz_data")]
        [XmlArrayItem("open_api_organization_node_info")]
        public List<OpenApiOrganizationNodeInfo> BizData { get; set; }
    }
}
