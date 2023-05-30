using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceOrganizationqueryallQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceOrganizationqueryallQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询返回的组织节点
        /// </summary>
        [XmlArray("biz_data")]
        [XmlArrayItem("open_api_organization_node_info")]
        public List<OpenApiOrganizationNodeInfo> BizData { get; set; }
    }
}
