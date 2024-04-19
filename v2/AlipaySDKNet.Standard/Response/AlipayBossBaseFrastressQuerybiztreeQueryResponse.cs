using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseFrastressQuerybiztreeQueryResponse.
    /// </summary>
    public class AlipayBossBaseFrastressQuerybiztreeQueryResponse : AopResponse
    {
        /// <summary>
        /// BizTreeNode
        /// </summary>
        [XmlArray("biz_tree_node_result")]
        [XmlArrayItem("biz_tree_node_with_no_recursive")]
        public List<BizTreeNodeWithNoRecursive> BizTreeNodeResult { get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 树id
        /// </summary>
        [XmlElement("tree_id")]
        public string TreeId { get; set; }
    }
}
