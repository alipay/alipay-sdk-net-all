using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderGroupmealOpenauthCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderGroupmealOpenauthCancelModel : AopObject
    {
        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("logic_group_id")]
        public string LogicGroupId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("uid_list")]
        [XmlArrayItem("string")]
        public List<string> UidList { get; set; }
    }
}
