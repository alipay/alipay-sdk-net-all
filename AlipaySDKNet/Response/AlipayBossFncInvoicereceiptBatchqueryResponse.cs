using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInvoicereceiptBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncInvoicereceiptBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回结果对象：可开票单据
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("ar_invoice_receipt_open_api_response")]
        public List<ArInvoiceReceiptOpenApiResponse> ResultSet { get; set; }

        /// <summary>
        /// 可开票总金额，可开票单据返回集合中可开票金额汇总
        /// </summary>
        [XmlElement("total_inv_amt")]
        public MultiCurrencyMoneyOpenApi TotalInvAmt { get; set; }

        /// <summary>
        /// 已开票总金额，可开票单据返回集合中已开票金额汇总
        /// </summary>
        [XmlElement("total_inved_amt")]
        public MultiCurrencyMoneyOpenApi TotalInvedAmt { get; set; }

        /// <summary>
        /// 关联票总金额，可开票单据返回集合中关联金额汇总
        /// </summary>
        [XmlElement("total_link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi TotalLinkInvoiceAmt { get; set; }
    }
}
