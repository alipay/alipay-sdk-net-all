using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoApplyidQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoApplyidQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票信息
        /// </summary>
        [XmlArray("invoice_info")]
        [XmlArrayItem("invoice_query_open_model")]
        public List<InvoiceQueryOpenModel> InvoiceInfo { get; set; }
    }
}
