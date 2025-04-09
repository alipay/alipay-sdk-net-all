using System;
using System.Xml.Serialization;
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
        [XmlElement("invoice_product_list")]
        public InvoiceProductInfo InvoiceProductList { get; set; }
    }
}
