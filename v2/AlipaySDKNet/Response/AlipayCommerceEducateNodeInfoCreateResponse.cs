using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateNodeInfoCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateNodeInfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建的组织节点ID，如果组织节点已被创建，则返回原组织节点ID。
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }
    }
}
