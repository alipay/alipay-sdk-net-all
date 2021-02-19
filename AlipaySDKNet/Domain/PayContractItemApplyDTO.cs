using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayContractItemApplyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayContractItemApplyDTO : AopObject
    {
        /// <summary>
        /// 已收票金额
        /// </summary>
        [XmlElement("invoice_received_amount")]
        public MultiCurrencyMoneyOpenApi InvoiceReceivedAmount { get; set; }

        /// <summary>
        /// 已发起付款金额
        /// </summary>
        [XmlElement("issued_amount")]
        public MultiCurrencyMoneyOpenApi IssuedAmount { get; set; }

        /// <summary>
        /// 付款条款行号
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 条款行类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 是否有票
        /// </summary>
        [XmlElement("need_invoice")]
        public bool NeedInvoice { get; set; }

        /// <summary>
        /// 已付金额
        /// </summary>
        [XmlElement("paid_amount")]
        public MultiCurrencyMoneyOpenApi PaidAmount { get; set; }

        /// <summary>
        /// 付款参照类型
        /// </summary>
        [XmlElement("pay_ref_type")]
        public string PayRefType { get; set; }

        /// <summary>
        /// 付款期限
        /// </summary>
        [XmlElement("pay_term")]
        public string PayTerm { get; set; }

        /// <summary>
        /// 付款期限类型
        /// </summary>
        [XmlElement("pay_term_type")]
        public string PayTermType { get; set; }

        /// <summary>
        /// 付款条款申请的可付金额-不变
        /// </summary>
        [XmlElement("payable_amount")]
        public MultiCurrencyMoneyOpenApi PayableAmount { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 条款类型
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 阶段
        /// </summary>
        [XmlElement("phase")]
        public long Phase { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 条款内容
        /// </summary>
        [XmlElement("terms")]
        public string Terms { get; set; }
    }
}
