using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseCtrRuleGroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseCtrRuleGroupInfo : AopObject
    {
        /// <summary>
        /// 费控条件列表
        /// </summary>
        [XmlArray("expense_ctrl_rule_info_list")]
        [XmlArrayItem("expense_ctr_rule_info")]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 费用类型 特殊说明：仅支持费用类型DEFAULT
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 费控规则ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 费控规则名称 约束： 1）敏感词校验 2）不能重复
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }
    }
}
