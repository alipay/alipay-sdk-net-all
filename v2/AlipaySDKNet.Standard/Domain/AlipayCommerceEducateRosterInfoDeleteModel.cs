using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateRosterInfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateRosterInfoDeleteModel : AopObject
    {
        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 要删除的花名册ID列表
        /// </summary>
        [XmlArray("roster_id_list")]
        [XmlArrayItem("string")]
        public List<string> RosterIdList { get; set; }
    }
}
