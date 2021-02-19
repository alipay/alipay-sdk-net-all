using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotSnRuleQueryResponse.
    /// </summary>
    public class AlipayCommerceIotSnRuleQueryResponse : AopResponse
    {
        /// <summary>
        /// profile规则列表
        /// </summary>
        [XmlArray("rule_list")]
        [XmlArrayItem("profile_rule_info")]
        public List<ProfileRuleInfo> RuleList { get; set; }
    }
}
