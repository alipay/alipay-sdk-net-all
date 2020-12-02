using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceLinkamtBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceLinkamtBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// Ar对账单发票关联明细集合
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("ar_invoice_bill_link_open_api_response")]
        public List<ArInvoiceBillLinkOpenApiResponse> ResultSet { get; set; }
    }
}
