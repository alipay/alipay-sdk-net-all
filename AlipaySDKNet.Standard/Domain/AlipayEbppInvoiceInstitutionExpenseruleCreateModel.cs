using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionExpenseruleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInstitutionExpenseruleCreateModel : AopObject
    {
        /// <summary>
        /// 企业共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 消费模式，该使用规则支持消费的资产类型，不填为默认模式，默认模式为优先消费余额，没有余额则根据规则中设置的限额控制消费金额
        /// </summary>
        [XmlElement("consume_mode")]
        public string ConsumeMode { get; set; }

        /// <summary>
        /// 企业码id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 使用规则条件列表
        /// </summary>
        [XmlElement("expense_ctrl_rule_info_list")]
        public ExpenseCtrRuleInfo ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 开票规则id，若使用途径是外卖的使用规则需要开票，需要在创建使用规则时关联开票规则，后续变更关联开票规则不生效
        /// </summary>
        [XmlElement("open_rule_id")]
        public string OpenRuleId { get; set; }

        /// <summary>
        /// 当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略
        /// </summary>
        [XmlElement("payment_policy")]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 使用规则描述(敏感词校验)
        /// </summary>
        [XmlElement("standard_desc")]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 费控规则名称 特殊说明： 1）敏感词校验
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
