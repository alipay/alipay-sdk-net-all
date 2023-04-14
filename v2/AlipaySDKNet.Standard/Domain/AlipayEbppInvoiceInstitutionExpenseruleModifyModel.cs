using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionExpenseruleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInstitutionExpenseruleModifyModel : AopObject
    {
        /// <summary>
        /// 企业共同账户id，和授权签约协议号共同使用。
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 修改使用规则，操作枚举： ADD_RULE（新增使用条件）， DELETE_RULE（删除使用条件）， MODIFY_RULE（修改使用条件），MODIFY_BASIC_INFO（修改规则基本信息）
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号，可通过签约消息获取。配合企业共同账户id使用，当填写企业共同账户id时，此字段必填。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 该使用规则支持的资产消费模式，不填写则为默认模式，默认模式下有余额时使用余额，没有余额则使用规则中的限额
        /// </summary>
        [XmlElement("consume_mode")]
        public string ConsumeMode { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 使用规则条件列表
        /// </summary>
        [XmlArray("expense_ctrl_rule_info_list")]
        [XmlArrayItem("expense_ctr_rule_info")]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 开票规则id，如果之前已关联开票规则，则更换开票规则id不生效
        /// </summary>
        [XmlElement("open_rule_id")]
        public string OpenRuleId { get; set; }

        /// <summary>
        /// 当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略COMBINATION
        /// </summary>
        [XmlElement("payment_policy")]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 规则条件列表
        /// </summary>
        [XmlArray("standard_condition_info_list")]
        [XmlArrayItem("standard_condition_info")]
        public List<StandardConditionInfo> StandardConditionInfoList { get; set; }

        /// <summary>
        /// 规则描述（敏感词校验）
        /// </summary>
        [XmlElement("standard_desc")]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 使用规则id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// 规则名称（敏感词校验）
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
