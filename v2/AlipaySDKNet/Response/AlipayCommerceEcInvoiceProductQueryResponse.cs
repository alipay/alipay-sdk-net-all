using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcInvoiceProductQueryResponse.
    /// </summary>
    public class AlipayCommerceEcInvoiceProductQueryResponse : AopResponse
    {
        /// <summary>
        /// 平台已发布发票产品列表
        /// </summary>
        [XmlArray("invoice_product_list")]
        [XmlArrayItem("invoice_product_info")]
        public List<InvoiceProductInfo> InvoiceProductList { get; set; }
    }
}
