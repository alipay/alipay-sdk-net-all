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
        /// 企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 修改操作 枚举值： ADD_RULE（新增费控条件），DELETE_RULE（删除费控条件），MODIFY_RULE（修改费控条件），MODIFY_STANDARD（修改费控规则基本信息）
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 有效期截止 特殊说明：修改费控规则基本信息时必传
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始 特殊说明：修改费控规则基本信息时必传
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业码企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 费控规则条件列表 特殊说明：新增费控条件/修改费控条件/删除费控条件操作时必填
        /// </summary>
        [XmlArray("expense_ctrl_rule_info_list")]
        [XmlArrayItem("expense_ctr_rule_info")]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）, COMBINATION（因公账户和个人账户组合支付）
        /// </summary>
        [XmlElement("payment_policy")]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 费控规则说明 特殊说明： 1）敏感词校验 2）修改费控规则基本信息时必传
        /// </summary>
        [XmlElement("standard_desc")]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 费控规则ID
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// 费控规则名称 特殊说明： 1）敏感词校验 2）修改费控规则基本信息时必传 3）不能重复，若需要重复联系支持人员定向放开
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
