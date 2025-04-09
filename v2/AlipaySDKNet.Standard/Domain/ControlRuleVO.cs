using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ControlRuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class ControlRuleVO : AopObject
    {
        /// <summary>
        /// 管控规则的key
        /// </summary>
        [XmlElement("rule_key")]
        public string RuleKey { get; set; }

        /// <summary>
        /// 管控规则内容
        /// </summary>
        [XmlElement("rule_value")]
        public string RuleValue { get; set; }
    }
}
