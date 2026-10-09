using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectrulesModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenserulesProjectrulesModifyModel : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 修改操作 枚举值：MODIFY_RULE（修改费控条件），仅支持MODIFY_RULE
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 费控规则列表
        /// </summary>
        [XmlArray("expense_ctrl_rule_info_group_list")]
        [XmlArrayItem("expense_ctr_rule_group_info")]
        public List<ExpenseCtrRuleGroupInfo> ExpenseCtrlRuleInfoGroupList { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
