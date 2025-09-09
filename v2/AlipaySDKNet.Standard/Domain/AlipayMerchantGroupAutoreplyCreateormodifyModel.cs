using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAutoreplyCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAutoreplyCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 修改操作必填
        /// </summary>
        [XmlElement("autoreply_id")]
        public string AutoreplyId { get; set; }

        /// <summary>
        /// 是否全局生效
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
        [XmlArray("rule_config_list")]
        [XmlArrayItem("group_msg_autoreply_rule_v_o")]
        public List<GroupMsgAutoreplyRuleVO> RuleConfigList { get; set; }
    }
}
