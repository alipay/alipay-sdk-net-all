using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel : AopObject
    {
        /// <summary>
        /// 共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号（仅使用account_id时必传）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 开票规则ID
        /// </summary>
        [XmlElement("invoice_rule_id")]
        public string InvoiceRuleId { get; set; }

        /// <summary>
        /// 开票名称
        /// </summary>
        [XmlElement("invoice_rule_name")]
        public string InvoiceRuleName { get; set; }

        /// <summary>
        /// 汇总开需要抬头，笔笔开不需要传抬头
        /// </summary>
        [XmlElement("invoice_title_id")]
        public string InvoiceTitleId { get; set; }

        /// <summary>
        /// 销方类型：TP开票、商户开票 枚举定义：MERCHANT（商户）、TP（TP）
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }
    }
}
