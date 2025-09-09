using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateNodeChildBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateNodeChildBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 组织节点列表
        /// </summary>
        [XmlArray("node_list")]
        [XmlArrayItem("edu_node_info")]
        public List<EduNodeInfo> NodeList { get; set; }
    }
}
