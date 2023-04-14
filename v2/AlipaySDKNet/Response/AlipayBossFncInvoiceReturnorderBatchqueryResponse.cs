using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceReturnorderBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceReturnorderBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回结果List
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("ar_invoice_return_order_open_api_response")]
        public List<ArInvoiceReturnOrderOpenApiResponse> ResultSet { get; set; }
    }
}
