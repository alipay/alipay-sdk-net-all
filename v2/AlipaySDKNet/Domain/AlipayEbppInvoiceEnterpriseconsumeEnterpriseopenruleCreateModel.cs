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
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 账期结束日期
        /// </summary>
        [XmlElement("bill_month_day")]
        public long BillMonthDay { get; set; }

        /// <summary>
        /// 开票账单范围
        /// </summary>
        [XmlElement("bill_scope")]
        public string BillScope { get; set; }

        /// <summary>
        /// 组合支付模式
        /// </summary>
        [XmlElement("combined_pay_mode")]
        public string CombinedPayMode { get; set; }

        /// <summary>
        /// 默认开票类型
        /// </summary>
        [XmlElement("default_invoice_kind")]
        public string DefaultInvoiceKind { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 发票备注取值规则。NONE表示不使用额度发放说明；QUOTA_ISSUE_DESC表示将因公付额度发放说明作为发票备注。不传、传null或空字符串时默认NONE。
        /// </summary>
        [XmlElement("invoice_remark_value_rule")]
        public string InvoiceRemarkValueRule { get; set; }

        /// <summary>
        /// 开票规则名称
        /// </summary>
        [XmlElement("invoice_rule_name")]
        public string InvoiceRuleName { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("invoice_title_id")]
        public string InvoiceTitleId { get; set; }

        /// <summary>
        /// 开票模式
        /// </summary>
        [XmlElement("open_mode")]
        public string OpenMode { get; set; }

        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("receive_address")]
        public string ReceiveAddress { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("receive_name")]
        public string ReceiveName { get; set; }

        /// <summary>
        /// 收件人手机号
        /// </summary>
        [XmlElement("receive_phone")]
        public string ReceivePhone { get; set; }

        /// <summary>
        /// 销方类型
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }

        /// <summary>
        /// 开票规则标记
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }
    }
}
