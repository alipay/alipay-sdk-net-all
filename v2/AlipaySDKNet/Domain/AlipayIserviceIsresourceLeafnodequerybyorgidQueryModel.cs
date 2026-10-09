using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceLeafnodequerybyorgidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceLeafnodequerybyorgidQueryModel : AopObject
    {
        /// <summary>
        /// 组织节点id
        /// </summary>
        [XmlElement("org_node_id")]
        public string OrgNodeId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
