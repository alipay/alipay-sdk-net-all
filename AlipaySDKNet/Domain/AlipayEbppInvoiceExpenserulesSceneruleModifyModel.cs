using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesSceneruleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenserulesSceneruleModifyModel : AopObject
    {
        /// <summary>
        /// 企业签约企业合花ID-共同账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 新增规则ADD_RULE/删除规则DELETE_RULE/修改规则MODIFY_RULE/修改制度基本信息MODIFY_STANDARD
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 有效期截止（修改制度基本信息的ACTION必填）
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始（修改制度基本信息的ACTION必填）
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 规则列表，新增规则/修改规则/删除规则操作是必填
        /// </summary>
        [XmlArray("expense_ctrl_rule_info_list")]
        [XmlArrayItem("expense_ctr_rule_info")]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 费控规则说明(修改制度基本信息的ACTION，否，不传则删除)
        /// </summary>
        [XmlElement("standard_desc")]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// 制度名称，修改制度基本信息的ACTION必填)
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
