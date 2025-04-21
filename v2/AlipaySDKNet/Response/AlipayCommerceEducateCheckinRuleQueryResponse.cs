using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCheckinRuleQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCheckinRuleQueryResponse : AopResponse
    {
        /// <summary>
        /// 签到规则详情
        /// </summary>
        [XmlElement("rule_info")]
        public EduCheckInRule RuleInfo { get; set; }
    }
}
