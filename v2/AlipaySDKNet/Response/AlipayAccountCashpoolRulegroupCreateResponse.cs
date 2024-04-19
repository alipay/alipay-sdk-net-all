using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountCashpoolRulegroupCreateResponse.
    /// </summary>
    public class AlipayAccountCashpoolRulegroupCreateResponse : AopResponse
    {
        /// <summary>
        /// 规则组ID
        /// </summary>
        [XmlElement("rule_group_id")]
        public string RuleGroupId { get; set; }
    }
}
