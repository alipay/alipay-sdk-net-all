using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardConditionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StandardConditionInfo : AopObject
    {
        /// <summary>
        /// 条件类型
        /// </summary>
        [XmlElement("rule_factor")]
        public string RuleFactor { get; set; }

        /// <summary>
        /// 费控条件ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 费控条件名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 费控条件操作符 枚举值： LT("<","小于") LE("<=","小于等于") EQ("=","等于") NE("!=","不等于") GE(">=","大于等于") GT(">","大于")
        /// </summary>
        [XmlElement("rule_operator")]
        public string RuleOperator { get; set; }

        /// <summary>
        /// 费控条件值
        /// </summary>
        [XmlElement("rule_value")]
        public string RuleValue { get; set; }
    }
}
