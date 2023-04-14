using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceRcptamountQueryResponse.
    /// </summary>
    public class AlipayBossFncOutputinvoiceRcptamountQueryResponse : AopResponse
    {
        /// <summary>
        /// 默认情况可开票总金额
        /// </summary>
        [XmlElement("total_inv_amt")]
        public MultiCurrencyMoneyOpenApi TotalInvAmt { get; set; }

        /// <summary>
        /// 默认开票模式下，已开票总金额，可开票单据返回集合中已开票金额汇总
        /// </summary>
        [XmlElement("total_inved_amt")]
        public MultiCurrencyMoneyOpenApi TotalInvedAmt { get; set; }

        /// <summary>
        /// 默认开票模式下，关联票总金额，可开票单据返回集合中关联金额汇总
        /// </summary>
        [XmlElement("total_link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi TotalLinkInvoiceAmt { get; set; }

        /// <summary>
        /// 应收开票时，总的可开票金额
        /// </summary>
        [XmlElement("total_receivable_inv_amt")]
        public MultiCurrencyMoneyOpenApi TotalReceivableInvAmt { get; set; }

        /// <summary>
        /// 按应收开票模式下，已开票总金额
        /// </summary>
        [XmlElement("total_receivable_inved_amt")]
        public MultiCurrencyMoneyOpenApi TotalReceivableInvedAmt { get; set; }

        /// <summary>
        /// 按应收开票模式下，已关联票总金额
        /// </summary>
        [XmlElement("total_receivable_link_inv_amt")]
        public MultiCurrencyMoneyOpenApi TotalReceivableLinkInvAmt { get; set; }

        /// <summary>
        /// 按实收开票模式下，总的可开票金额
        /// </summary>
        [XmlElement("total_writeoff_inv_amt")]
        public MultiCurrencyMoneyOpenApi TotalWriteoffInvAmt { get; set; }

        /// <summary>
        /// 按实收开票模式下，已开票金额
        /// </summary>
        [XmlElement("total_writeoff_inved_amt")]
        public MultiCurrencyMoneyOpenApi TotalWriteoffInvedAmt { get; set; }

        /// <summary>
        /// 按实收开票模式，已关联票总金额
        /// </summary>
        [XmlElement("total_writeoff_link_inv_amt")]
        public MultiCurrencyMoneyOpenApi TotalWriteoffLinkInvAmt { get; set; }
    }
}
