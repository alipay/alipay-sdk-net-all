using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleSyncStandardConditionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RuleSyncStandardConditionInfo : AopObject
    {
        /// <summary>
        /// 规则因子
        /// </summary>
        [XmlElement("rule_factor")]
        public string RuleFactor { get; set; }

        /// <summary>
        /// 使用规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 规则因子值
        /// </summary>
        [XmlElement("rule_value")]
        public string RuleValue { get; set; }
    }
}
