using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainGroupsAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTrainGroupsAddModel : AopObject
    {
        /// <summary>
        /// 机构群id
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }
    }
}
