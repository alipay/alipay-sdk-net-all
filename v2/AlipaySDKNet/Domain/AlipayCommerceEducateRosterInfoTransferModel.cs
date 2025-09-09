using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateRosterInfoTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateRosterInfoTransferModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 移动的目标组织部门节点id
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// 花名册id列表
        /// </summary>
        [XmlArray("roster_id_list")]
        [XmlArrayItem("string")]
        public List<string> RosterIdList { get; set; }
    }
}
