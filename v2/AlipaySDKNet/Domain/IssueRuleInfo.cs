using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IssueRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IssueRuleInfo : AopObject
    {
        /// <summary>
        /// 生效时间段
        /// </summary>
        [XmlElement("effective_period")]
        public string EffectivePeriod { get; set; }

        /// <summary>
        /// 累计类型，默认为0 枚举：0（不可累计）、1（可累计）、2（累计天数）、3（累计到指定日期）
        /// </summary>
        [XmlElement("invalid_mode")]
        public long InvalidMode { get; set; }

        /// <summary>
        /// 累计类型值
        /// </summary>
        [XmlElement("invalid_mode_value")]
        public string InvalidModeValue { get; set; }

        /// <summary>
        /// 发放金额
        /// </summary>
        [XmlElement("issue_amount_value")]
        public string IssueAmountValue { get; set; }

        /// <summary>
        /// 发放规则有效结束时间
        /// </summary>
        [XmlElement("issue_end_date")]
        public string IssueEndDate { get; set; }

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
        /// 发放规则有效起始时间
        /// </summary>
        [XmlElement("issue_start_date")]
        public string IssueStartDate { get; set; }

        /// <summary>
        /// 发放类型
        /// </summary>
        [XmlElement("issue_type")]
        public string IssueType { get; set; }

        /// <summary>
        /// 外部发放规则id
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 额度类型
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 是否可转赠
        /// </summary>
        [XmlElement("share_mode")]
        public long ShareMode { get; set; }

        /// <summary>
        /// 目标id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 发放规则归属的目标类型
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
