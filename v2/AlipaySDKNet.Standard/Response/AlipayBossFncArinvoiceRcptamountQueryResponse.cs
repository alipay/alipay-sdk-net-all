using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncArinvoiceRcptamountQueryResponse.
    /// </summary>
    public class AlipayBossFncArinvoiceRcptamountQueryResponse : AopResponse
    {
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
