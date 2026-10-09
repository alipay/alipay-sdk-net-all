using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseTimeRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseTimeRuleInfo : AopObject
    {
        /// <summary>
        /// 日期规则。当ruleType = DATE时，不能为空
        /// </summary>
        [XmlElement("date_rule_info")]
        public DateRuleInfo DateRuleInfo { get; set; }

        /// <summary>
        /// 节假日规则。当ruleType = HOLIDAY时，不能为空
        /// </summary>
        [XmlElement("holiday_rule_info")]
        public HolidayRuleInfo HolidayRuleInfo { get; set; }

        /// <summary>
        /// 规则类型
        /// </summary>
        [XmlElement("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 周期规则。当rule_type = WEEK时，不能为空
        /// </summary>
        [XmlElement("week_rule_info")]
        public WeekRuleInfo WeekRuleInfo { get; set; }
    }
}
