using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectruleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenserulesProjectruleCreateModel : AopObject
    {
        /// <summary>
        /// 共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 有效期截止（yyyy-MM-dd HH:mm:ss，必须大于起始时间）
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始（yyyy-MM-dd HH:mm:ss，必须小于截止时间）
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 切换open_id前使用此字段：员工支付宝ID列表 特殊说明：单次传入的最大员工数为50，后续通过修改项目的员工列表接口进行员工调整
        /// </summary>
        [XmlArray("employee_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeList { get; set; }

        /// <summary>
        /// 切换open_id后使用此字段：员工open_id列表 特殊说明：单次传入的最大员工数为50，后续通过修改项目的员工列表接口进行员工调整
        /// </summary>
        [XmlArray("employee_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeOpenIdList { get; set; }

        /// <summary>
        /// 费控规则列表
        /// </summary>
        [XmlArray("expense_ctrl_rule_info_group_list")]
        [XmlArrayItem("expense_ctr_rule_group_info")]
        public List<ExpenseCtrRuleGroupInfo> ExpenseCtrlRuleInfoGroupList { get; set; }

        /// <summary>
        /// 项目名称 约束： 1）敏感词校验 2）不能重复
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }
    }
}
