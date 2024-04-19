using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOrganizationNodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOrganizationNodeInfo : AopObject
    {
        /// <summary>
        /// 组织节点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// 父节点id
        /// </summary>
        [XmlElement("parent_node_id")]
        public string ParentNodeId { get; set; }

        /// <summary>
        /// 节点排序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }
    }
}
