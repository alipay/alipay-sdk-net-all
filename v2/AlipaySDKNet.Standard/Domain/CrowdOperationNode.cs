using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdOperationNode Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdOperationNode : AopObject
    {
        /// <summary>
        /// 节点id
        /// </summary>
        [XmlElement("node_code")]
        public string NodeCode { get; set; }

        /// <summary>
        /// 节点描述
        /// </summary>
        [XmlElement("node_desc")]
        public string NodeDesc { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 节点选项组
        /// </summary>
        [XmlElement("node_option_group")]
        public CrowdOperationNodeOptionGroup NodeOptionGroup { get; set; }

        /// <summary>
        /// 节点选项组id
        /// </summary>
        [XmlElement("node_option_group_id")]
        public string NodeOptionGroupId { get; set; }

        /// <summary>
        /// 节点展示类型
        /// </summary>
        [XmlElement("node_show_type")]
        public string NodeShowType { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [XmlElement("node_type")]
        public string NodeType { get; set; }

        /// <summary>
        /// 父节点id
        /// </summary>
        [XmlElement("parent_node_code")]
        public string ParentNodeCode { get; set; }
    }
}
