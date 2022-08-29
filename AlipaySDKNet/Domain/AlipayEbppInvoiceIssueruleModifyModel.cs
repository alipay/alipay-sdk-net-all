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
        /// 共同账户id - 适用于在企业码小程序创建的共同账户，和agreement_no搭配使用
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
        /// 是否启用，"0"为停用，"1"为启用； 如果target_type指定INSTITUTION，则与制度一致
        /// </summary>
        [XmlElement("effective")]
        public string Effective { get; set; }

        /// <summary>
        /// 生效周期（不传则不修改），不限："{\"all\":true}"
        /// </summary>
        [XmlElement("effective_period")]
        public string EffectivePeriod { get; set; }

        /// <summary>
        /// 企业ID - 适用于在企业码PC端创建的企业账号
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 是否可累计（不传则不修改），枚举：0（不可累计）、1（可累计），默认为0，余额只允许可累计，按城市发放只允许不可累计，设置了生效周期只允许不可累计
        /// </summary>
        [XmlElement("invalid_mode")]
        public long InvalidMode { get; set; }

        /// <summary>
        /// 累计值（预留字段）
        /// </summary>
        [XmlElement("invalid_mode_value")]
        public string InvalidModeValue { get; set; }

        /// <summary>
        /// 发放金额（不传则不修改）； 按城市不同发放标准示例值："[{\"cities\":[\"321000\",\"321100\"],\"amount\":\"50\"},{\"cities\":[\"321200\",\"321300\"],\"amount\":\"150\"}]" 统一标准发放示例值："200"
        /// </summary>
        [XmlElement("issue_amount_value")]
        public string IssueAmountValue { get; set; }

        /// <summary>
        /// 发放规则的截止时间 如果target_type指定INSTITUTION，则使用制度有效期结束时间，无需填写
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
        /// 发放规则的开始时间 如果target_type指定INSTITUTION，则使用制度有效期起始时间，不支持修改
        /// </summary>
        [XmlElement("issue_start_date")]
        public string IssueStartDate { get; set; }

        /// <summary>
        /// 发放类型（不传则不修改），枚举：ISSUE_MONTH（按月发放）、ISSUE_DAY（按日发放）
        /// </summary>
        [XmlElement("issue_type")]
        public string IssueType { get; set; }

        /// <summary>
        /// 额度类型（不传则不修改），枚举：COUPON（点券）、CAP（余额）
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 是否可转赠（不传则不修改），枚举：0（不可转赠）、1（可转赠），默认为0，余额不支持可转赠，按城市发放不支持可转赠
        /// </summary>
        [XmlElement("share_mode")]
        public long ShareMode { get; set; }

        /// <summary>
        /// 发放规则关联的目标值 target_type为制度时：制度id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 发放规则关联的目标类型，枚举值：INSTITUTION(制度)
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
