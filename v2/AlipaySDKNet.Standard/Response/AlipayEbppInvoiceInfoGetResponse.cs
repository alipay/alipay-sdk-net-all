using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoGetResponse : AopResponse
    {
        /// <summary>
        /// 电子发票详情模型
        /// </summary>
        [XmlElement("invoice_model")]
        public InvoiceModelContent InvoiceModel { get; set; }
    }
}
