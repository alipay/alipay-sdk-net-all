using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ModifyIssueRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ModifyIssueRuleInfo : AopObject
    {
        /// <summary>
        /// 发放资产的有效时间段，该字段为空时，默认为不限制。当发放资产为余额时，仅支持设置为不限，当发放资产为点券时，可支持设置多种值。具体传值格式请参考文档 <a href="https://opendocs.alipay.com/pre-open/07nwcs">接入文档</a>
        /// </summary>
        [XmlElement("effective_period")]
        public string EffectivePeriod { get; set; }

        /// <summary>
        /// 累计类型，默认为0 可选值：0（不可累计）、1（可累计）、2（累计天数）、3（累计到指定日期）
        /// </summary>
        [XmlElement("invalid_mode")]
        public long InvalidMode { get; set; }

        /// <summary>
        /// 累计类型值
        /// </summary>
        [XmlElement("invalid_mode_value")]
        public string InvalidModeValue { get; set; }

        /// <summary>
        /// 发放金额（不传则不修改），单位（元）
        /// </summary>
        [XmlElement("issue_amount_value")]
        public string IssueAmountValue { get; set; }

        /// <summary>
        /// 发放规则id
        /// </summary>
        [XmlElement("issue_rule_id")]
        public string IssueRuleId { get; set; }

        /// <summary>
        /// 发放规则名称
        /// </summary>
        [XmlElement("issue_rule_name")]
        public string IssueRuleName { get; set; }

        /// <summary>
        /// 额度发放周期
        /// </summary>
        [XmlElement("issue_type")]
        public string IssueType { get; set; }

        /// <summary>
        /// 发放规则发放的额度类型
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 是否可转赠（不传则不修改），可选值：0（不可转赠）、1（可转赠），默认为0。该字段决定发放规则发放的资产是否可转赠给同制度下的其他人员
        /// </summary>
        [XmlElement("share_mode")]
        public long ShareMode { get; set; }
    }
}
