using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCheckinRuleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCheckinRuleDeleteModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }
    }
}
