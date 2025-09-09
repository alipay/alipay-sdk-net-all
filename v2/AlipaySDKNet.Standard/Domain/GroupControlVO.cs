using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupControlVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupControlVO : AopObject
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

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
