using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceIssueruleCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceIssueruleCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建的发放规则ID
        /// </summary>
        [XmlElement("issue_rule_id")]
        public string IssueRuleId { get; set; }
    }
}
