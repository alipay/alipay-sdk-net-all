using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponse : AopResponse
    {
        /// <summary>
        /// 开票规则id
        /// </summary>
        [XmlElement("invoice_rule_id")]
        public string InvoiceRuleId { get; set; }
    }
}
