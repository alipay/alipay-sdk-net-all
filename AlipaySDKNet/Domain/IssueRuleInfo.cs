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
        /// 生效周期，不限："{\"all\":true}"，默认为不限
        /// </summary>
        [XmlElement("effective_period")]
        public string EffectivePeriod { get; set; }

        /// <summary>
        /// 是否可累计，枚举：0（不可累计）、1（可累计），默认为0
        /// </summary>
        [XmlElement("invalid_mode")]
        public long InvalidMode { get; set; }

        /// <summary>
        /// 失效模式值
        /// </summary>
        [XmlElement("invalid_mode_value")]
        public string InvalidModeValue { get; set; }

        /// <summary>
        /// 发放金额，按城市不同发放标准示例值："[{/"cities/":[/"321000/",/"321100/"],amount:/"50/"}, {/"cities/":[/"321200/",/"321300/"],amount:/"150/"}]" 统一标准发放示例值：200
        /// </summary>
        [XmlElement("issue_amount_value")]
        public string IssueAmountValue { get; set; }

        /// <summary>
        /// 如果target_type指定INSTITUTION，则使用制度有效期结束时间，无需填写
        /// </summary>
        [XmlElement("issue_end_date")]
        public string IssueEndDate { get; set; }

        /// <summary>
        /// 发放规则id，创建时无需填写
        /// </summary>
        [XmlElement("issue_rule_id")]
        public string IssueRuleId { get; set; }

        /// <summary>
        /// 发放规则名称
        /// </summary>
        [XmlElement("issue_rule_name")]
        public string IssueRuleName { get; set; }

        /// <summary>
        /// 如果target_type指定INSTITUTION，则使用制度有效期起始时间，无需填写
        /// </summary>
        [XmlElement("issue_start_date")]
        public string IssueStartDate { get; set; }

        /// <summary>
        /// 发放类型，枚举：ISSUE_MONTH（按月发放）、ISSUE_DAY（按日发放）
        /// </summary>
        [XmlElement("issue_type")]
        public string IssueType { get; set; }

        /// <summary>
        /// 外部发放规则id，制度内发放规则该字段不允许重复
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 额度类型，枚举：COUPON（点券）、CAP（余额）
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 是否可转赠，枚举：0（不可转赠）、1（可转赠），默认为0
        /// </summary>
        [XmlElement("share_mode")]
        public long ShareMode { get; set; }
    }
}
