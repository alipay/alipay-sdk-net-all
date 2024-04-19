using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentApplyResponseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentApplyResponseDTO : AopObject
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_relative_id")]
        public string ApplyRelativeId { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 是否是质量保证金额
        /// </summary>
        [XmlElement("guarantee_noney")]
        public string GuaranteeNoney { get; set; }

        /// <summary>
        /// OU代码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// OU名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 应票金额
        /// </summary>
        [XmlElement("invaccept_receivable_amt")]
        public MultiCurrencyMoneyOpenApi InvacceptReceivableAmt { get; set; }

        /// <summary>
        /// 关联发票受理单，已票金额
        /// </summary>
        [XmlElement("invaccept_relevant_amt")]
        public MultiCurrencyMoneyOpenApi InvacceptRelevantAmt { get; set; }

        /// <summary>
        /// 可票金额 (固定不变的，不会根据已票金额变化而变化)
        /// </summary>
        [XmlElement("invoice_receivable_amount")]
        public MultiCurrencyMoneyOpenApi InvoiceReceivableAmount { get; set; }

        /// <summary>
        /// 已认证金额
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
        /// 付款描述
        /// </summary>
        [XmlElement("pay_contract_desc")]
        public string PayContractDesc { get; set; }

        /// <summary>
        /// 付款条款行ID
        /// </summary>
        [XmlElement("pay_contract_item_no")]
        public string PayContractItemNo { get; set; }

        /// <summary>
        /// 可付款金额
        /// </summary>
        [XmlElement("payable_amount")]
        public MultiCurrencyMoneyOpenApi PayableAmount { get; set; }

        /// <summary>
        /// RT号
        /// </summary>
        [XmlElement("rt_no")]
        public string RtNo { get; set; }

        /// <summary>
        /// 状态：已结算、未结算、部分结算
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 付款阶段
        /// </summary>
        [XmlElement("stage")]
        public string Stage { get; set; }

        /// <summary>
        /// 开票资料-账号
        /// </summary>
        [XmlElement("tax_account_no")]
        public string TaxAccountNo { get; set; }

        /// <summary>
        /// 开票资料-地址
        /// </summary>
        [XmlElement("tax_address")]
        public string TaxAddress { get; set; }

        /// <summary>
        /// 发票税额
        /// </summary>
        [XmlElement("tax_amount")]
        public MultiCurrencyMoneyOpenApi TaxAmount { get; set; }

        /// <summary>
        /// 开票资料-银行
        /// </summary>
        [XmlElement("tax_bank_name")]
        public string TaxBankName { get; set; }

        /// <summary>
        /// 开票资料-名称
        /// </summary>
        [XmlElement("tax_invoice_title")]
        public string TaxInvoiceTitle { get; set; }

        /// <summary>
        /// 开票资料-电话
        /// </summary>
        [XmlElement("tax_phone_no")]
        public string TaxPhoneNo { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 开票资料-税号
        /// </summary>
        [XmlElement("tax_tax_no")]
        public string TaxTaxNo { get; set; }

        /// <summary>
        /// 开票资料-类型
        /// </summary>
        [XmlElement("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 开票资料-类型名称
        /// </summary>
        [XmlElement("tax_type_desc")]
        public string TaxTypeDesc { get; set; }

        /// <summary>
        /// 待付款金额=可付金额-已发起付款金额
        /// </summary>
        [XmlElement("to_pay_amount")]
        public MultiCurrencyMoneyOpenApi ToPayAmount { get; set; }

        /// <summary>
        /// 未确认金额=已票金额-已认证
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
