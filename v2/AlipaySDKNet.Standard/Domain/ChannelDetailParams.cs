using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelDetailParams Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelDetailParams : AopObject
    {
        /// <summary>
        /// 预付卡分组名称
        /// </summary>
        [XmlElement("card_group_name")]
        public string CardGroupName { get; set; }

        /// <summary>
        /// 风控咨询结果
        /// </summary>
        [XmlElement("credit_risk_info")]
        public string CreditRiskInfo { get; set; }

        /// <summary>
        /// 是否先采后付垫资版,用于先采后付前置咨询
        /// </summary>
        [XmlElement("fund_loan_sign")]
        public string FundLoanSign { get; set; }

        /// <summary>
        /// 国家贴息
        /// </summary>
        [XmlElement("gov_subsidy")]
        public string GovSubsidy { get; set; }

        /// <summary>
        /// 银行贴息
        /// </summary>
        [XmlElement("inst_subsidy")]
        public string InstSubsidy { get; set; }

        /// <summary>
        /// 芝麻人群标签
        /// </summary>
        [XmlElement("marketing_flag")]
        public string MarketingFlag { get; set; }

        /// <summary>
        /// 芝麻拒绝原因
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 芝麻对外部商户用户是否有意愿开通芝麻免密下单的意愿分级，1为高意愿用户，0为低意向用户
        /// </summary>
        [XmlElement("use_agreement_pay_willingness")]
        public string UseAgreementPayWillingness { get; set; }

        /// <summary>
        /// 用户是否已签约
        /// </summary>
        [XmlElement("user_has_sign")]
        public string UserHasSign { get; set; }

        /// <summary>
        /// "true"：芝麻分大于等于800分 "false":  芝麻分小于800分
        /// </summary>
        [XmlElement("zm_score_gte_800")]
        public string ZmScoreGte800 { get; set; }
    }
}
