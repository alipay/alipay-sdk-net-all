using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizTreeNodeWithNoRecursive Data Structure.
    /// </summary>
    [Serializable]
    public class BizTreeNodeWithNoRecursive : AopObject
    {
        /// <summary>
        /// 是否有孩子节点。0表示无 1表示有
        /// </summary>
        [XmlElement("has_children")]
        public string HasChildren { get; set; }

        /// <summary>
        /// CODE
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 父节点标记
        /// </summary>
        [XmlElement("parent_node_id")]
        public string ParentNodeId { get; set; }

        /// <summary>
        /// sequence
        /// </summary>
        [XmlElement("sequence")]
        public string Sequence { get; set; }
    }
}
