using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgAutoreplyDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgAutoreplyDetailVO : AopObject
    {
        /// <summary>
        /// 自动回复id
        /// </summary>
        [XmlElement("autoreply_id")]
        public string AutoreplyId { get; set; }

        /// <summary>
        /// 是否全局生效
        /// </summary>
        [XmlElement("global_valid")]
        public bool GlobalValid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

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

        /// <summary>
        /// 状态  0 删除，2 启用，3 停用
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
