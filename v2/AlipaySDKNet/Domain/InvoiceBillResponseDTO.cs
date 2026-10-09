using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceBillResponseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceBillResponseDTO : AopObject
    {
        /// <summary>
        /// 申请单聚合键
        /// </summary>
        [XmlElement("apply_relative_id")]
        public string ApplyRelativeId { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 机构
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 关联发票受理单应票金额
        /// </summary>
        [XmlElement("invaccept_receivable_amt")]
        public MultiCurrencyMoneyOpenApi InvacceptReceivableAmt { get; set; }

        /// <summary>
        /// 关联发票受理单已票金额
        /// </summary>
        [XmlElement("invaccept_relevant_amt")]
        public MultiCurrencyMoneyOpenApi InvacceptRelevantAmt { get; set; }

        /// <summary>
        /// 可票金额 (固定不变的，不会根据已票金额变化而变化)*
        /// </summary>
        [XmlElement("invoice_receivable_amount")]
        public MultiCurrencyMoneyOpenApi InvoiceReceivableAmount { get; set; }

        /// <summary>
        /// 已票金额（发票中心-发票认证时才会更新）
        /// </summary>
        [XmlElement("invoice_received_amount")]
        public MultiCurrencyMoneyOpenApi InvoiceReceivedAmount { get; set; }

        /// <summary>
        /// 已发起付款金额
        /// </summary>
        [XmlElement("issued_paid_amount")]
        public MultiCurrencyMoneyOpenApi IssuedPaidAmount { get; set; }

        /// <summary>
        /// 开票号
        /// </summary>
        [XmlElement("kp_no")]
        public string KpNo { get; set; }

        /// <summary>
        /// 已付款金额
        /// </summary>
        [XmlElement("paid_amount")]
        public MultiCurrencyMoneyOpenApi PaidAmount { get; set; }

        /// <summary>
        /// 可付款金额
        /// </summary>
        [XmlElement("payable_amount")]
        public MultiCurrencyMoneyOpenApi PayableAmount { get; set; }

        /// <summary>
        /// 结算状态
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 关联发票税额
        /// </summary>
        [XmlElement("tax_amount")]
        public MultiCurrencyMoneyOpenApi TaxAmount { get; set; }

        /// <summary>
        /// 待付款金额=可付金额-已发起付款金额
        /// </summary>
        [XmlElement("to_pay_amount")]
        public MultiCurrencyMoneyOpenApi ToPayAmount { get; set; }

        /// <summary>
        /// 未票金额=应票金额-已票金额
        /// </summary>
        [XmlElement("un_invoice_received_amount")]
        public MultiCurrencyMoneyOpenApi UnInvoiceReceivedAmount { get; set; }

        /// <summary>
        /// 已核销金额
        /// </summary>
        [XmlElement("wroteoff_amount")]
        public MultiCurrencyMoneyOpenApi WroteoffAmount { get; set; }
    }
}
