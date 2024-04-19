using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantApplyModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceMerchantApplyModifyResponse : AopResponse
    {
        /// <summary>
        /// 同一批次下未归集成功的发票
        /// </summary>
        [XmlArray("error_invoices")]
        [XmlArrayItem("merchant_invoice_u_k_d_t_o")]
        public List<MerchantInvoiceUKDTO> ErrorInvoices { get; set; }
    }
}
