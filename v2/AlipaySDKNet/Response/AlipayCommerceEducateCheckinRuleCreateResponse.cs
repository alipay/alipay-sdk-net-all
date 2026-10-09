using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCheckinRuleCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateCheckinRuleCreateResponse : AopResponse
    {
        /// <summary>
        /// 签到规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }
    }
}
