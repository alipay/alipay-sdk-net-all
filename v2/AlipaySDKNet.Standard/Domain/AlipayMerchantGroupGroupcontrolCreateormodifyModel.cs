using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupcontrolCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupcontrolCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 命中处理方式
        /// </summary>
        [XmlElement("action")]
        public GroupControlActionVO Action { get; set; }

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
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("role_list")]
        [XmlArrayItem("string")]
        public List<string> RoleList { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("rule_list")]
        [XmlArrayItem("group_control_rule_v_o")]
        public List<GroupControlRuleVO> RuleList { get; set; }
    }
}
