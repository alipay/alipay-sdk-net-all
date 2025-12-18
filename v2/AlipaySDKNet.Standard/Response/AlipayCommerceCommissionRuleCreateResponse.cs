using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommissionRuleCreateResponse.
    /// </summary>
    public class AlipayCommerceCommissionRuleCreateResponse : AopResponse
    {
        /// <summary>
        /// 规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }
    }
}
