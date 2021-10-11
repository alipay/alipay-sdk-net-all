using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponse : AopResponse
    {
        /// <summary>
        /// 开票规则信息
        /// </summary>
        [XmlElement("enterprise_open_rule_info")]
        public EnterpriseOpenRuleInfo EnterpriseOpenRuleInfo { get; set; }
    }
}
