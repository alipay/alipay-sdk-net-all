using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryModel : AopObject
    {
        /// <summary>
        /// 企业签约企业合花ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 开票规则id
        /// </summary>
        [XmlElement("invoice_rule_id")]
        public string InvoiceRuleId { get; set; }
    }
}
