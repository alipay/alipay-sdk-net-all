using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel : AopObject
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
        /// 账期结束日期，可选范围1-31，只有汇总开需要
        /// </summary>
        [XmlElement("bill_month_day")]
        public long BillMonthDay { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 开票规则名称
        /// </summary>
        [XmlElement("invoice_rule_name")]
        public string InvoiceRuleName { get; set; }

        /// <summary>
        /// 汇总开需要抬头，笔笔开不需要传抬头
        /// </summary>
        [XmlElement("invoice_title_id")]
        public string InvoiceTitleId { get; set; }

        /// <summary>
        /// 开票模式：汇总开、笔笔开 枚举定义：SUMMARY:汇总开 SINGLE:单笔开
        /// </summary>
        [XmlElement("open_mode")]
        public string OpenMode { get; set; }

        /// <summary>
        /// 销方类型：TP开票、商户开票， 枚举定义：MERCHANT（商户）、TP（TP），不填默认商户
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }

        /// <summary>
        /// 开票规则标记： DEFAULT-默认 EMPLOYEE_TITLE_FIRST-员工签约抬头优先于开票规则
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }
    }
}
