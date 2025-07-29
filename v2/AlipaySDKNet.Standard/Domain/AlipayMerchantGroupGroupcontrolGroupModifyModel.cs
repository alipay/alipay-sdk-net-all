using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupcontrolGroupModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupcontrolGroupModifyModel : AopObject
    {
        /// <summary>
        /// 是否全部群组
        /// </summary>
        [XmlElement("global_valid")]
        public bool GlobalValid { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("group_id_list")]
        [XmlArrayItem("string")]
        public List<string> GroupIdList { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }
    }
}
