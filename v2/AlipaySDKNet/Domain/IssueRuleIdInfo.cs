using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IssueRuleIdInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IssueRuleIdInfo : AopObject
    {
        /// <summary>
        /// 发放规则id
        /// </summary>
        [XmlElement("issue_rule_id")]
        public string IssueRuleId { get; set; }

        /// <summary>
        /// 外部发放规则id
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }
    }
}
