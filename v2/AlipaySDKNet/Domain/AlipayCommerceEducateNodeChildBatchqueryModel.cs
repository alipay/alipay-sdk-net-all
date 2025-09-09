using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateNodeChildBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateNodeChildBatchqueryModel : AopObject
    {
        /// <summary>
        /// 结构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 节点ID，如果不传则查询学校下的第一级组织节点
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }
    }
}
