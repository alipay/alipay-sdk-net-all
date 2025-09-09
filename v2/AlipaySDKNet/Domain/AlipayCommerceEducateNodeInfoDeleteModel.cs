using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateNodeInfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateNodeInfoDeleteModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 组织节点ID
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }
    }
}
