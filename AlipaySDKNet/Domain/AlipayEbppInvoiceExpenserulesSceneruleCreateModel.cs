using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesSceneruleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenserulesSceneruleCreateModel : AopObject
    {
        /// <summary>
        /// 企业签约企业合花ID-共同账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 有效期截止
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 员工支付宝uid列表
        /// </summary>
        [XmlArray("employee_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeList { get; set; }

        /// <summary>
        /// 规则列表
        /// </summary>
        [XmlArray("expense_ctrl_rule_info_list")]
        [XmlArrayItem("expense_ctr_rule_info")]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 费用类型（餐饮：MEAL，地铁：METRO）
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 场景类型（ 加班场景：OVERTIME，补贴福利：SUBSIDY，差旅：TRAVEL ）
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 费控规则说明
        /// </summary>
        [XmlElement("standard_desc")]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 制度名称
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
