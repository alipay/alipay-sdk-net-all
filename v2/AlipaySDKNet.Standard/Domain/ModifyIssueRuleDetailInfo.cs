using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ModifyIssueRuleDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ModifyIssueRuleDetailInfo : AopObject
    {
        /// <summary>
        /// 新增发放规则列表
        /// </summary>
        [XmlArray("add_issue_rule_list")]
        [XmlArrayItem("issue_rule_info")]
        public List<IssueRuleInfo> AddIssueRuleList { get; set; }

        /// <summary>
        /// 删除的发放规则id列表
        /// </summary>
        [XmlArray("delete_issue_rule_id_list")]
        [XmlArrayItem("string")]
        public List<string> DeleteIssueRuleIdList { get; set; }

        /// <summary>
        /// 修改发放规则列表
        /// </summary>
        [XmlElement("modify_issue_rule_list")]
        public ModifyIssueRuleInfo ModifyIssueRuleList { get; set; }
    }
}
