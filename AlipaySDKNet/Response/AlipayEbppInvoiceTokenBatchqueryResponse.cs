using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTokenBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTokenBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 发票要素列表
        /// </summary>
        [XmlArray("invoice_element_list")]
        [XmlArrayItem("invoice_element_model")]
        public List<InvoiceElementModel> InvoiceElementList { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
