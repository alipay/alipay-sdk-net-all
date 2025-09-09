using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcInvoiceClerkQueryResponse.
    /// </summary>
    public class AlipayCommerceEcInvoiceClerkQueryResponse : AopResponse
    {
        /// <summary>
        /// 开票员列表
        /// </summary>
        [XmlArray("invoice_clerk_list")]
        [XmlArrayItem("leqi_invoice_clerk")]
        public List<LeqiInvoiceClerk> InvoiceClerkList { get; set; }
    }
}
