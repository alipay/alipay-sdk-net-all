using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceIssueruleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceIssueruleModifyModel : AopObject
    {
        /// <summary>
        /// 共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 修改类型，枚举： MODIFY_BASIC_INFO（修改发放规则基本信息）
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 是否启用，"0"为停用，"1"为启用；
        /// </summary>
        [XmlElement("effective")]
        public string Effective { get; set; }

        /// <summary>
        /// 生效周期（不传则不修改），不限："{\"all\":true}"
        /// </summary>
        [XmlElement("effective_period")]
        public string EffectivePeriod { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 是否可累计（不传则不修改）可选值：0（不可累计）、1（可累计），2（累计天数），3（累计到固定时间）
        /// </summary>
        [XmlElement("invalid_mode")]
        public long InvalidMode { get; set; }

        /// <summary>
        /// 累计值
        /// </summary>
        [XmlElement("invalid_mode_value")]
        public string InvalidModeValue { get; set; }

        /// <summary>
        /// 发放金额（不传则不修改），单位（元）
        /// </summary>
        [XmlElement("issue_amount_value")]
        public string IssueAmountValue { get; set; }

        /// <summary>
        /// 发放规则的截止时间
        /// </summary>
        [XmlElement("issue_end_date")]
        public string IssueEndDate { get; set; }

        /// <summary>
        /// 发放规则id
        /// </summary>
        [XmlElement("issue_rule_id")]
        public string IssueRuleId { get; set; }

        /// <summary>
        /// 发放规则名称（不传则不修改）
        /// </summary>
        [XmlElement("issue_rule_name")]
        public string IssueRuleName { get; set; }

        /// <summary>
        /// 发放规则的开始时间
        /// </summary>
        [XmlElement("issue_start_date")]
        public string IssueStartDate { get; set; }

        /// <summary>
        /// 发放类型
        /// </summary>
        [XmlElement("issue_type")]
        public string IssueType { get; set; }

        /// <summary>
        /// 额度类型
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 是否可转赠（不传则不修改），可选值：0（不可转赠）、1（可转赠），默认为0，按城市发放不支持可转赠
        /// </summary>
        [XmlElement("share_mode")]
        public long ShareMode { get; set; }

        /// <summary>
        /// 发放规则关联的目标值 target_type为制度时：制度id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 发放规则关联的目标类型
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
