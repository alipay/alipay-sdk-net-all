using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupJoinRuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupJoinRuleVO : AopObject
    {
        /// <summary>
        /// 入群规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 入群规则类型
        /// </summary>
        [XmlElement("rule_type")]
        public string RuleType { get; set; }
    }
}
