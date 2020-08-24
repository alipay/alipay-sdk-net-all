using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransInvoiceSyncdataModifyResponse.
    /// </summary>
    public class AlipayFundTransInvoiceSyncdataModifyResponse : AopResponse
    {
        /// <summary>
        /// 票据详情页url
        /// </summary>
        [XmlElement("invoice_url")]
        public string InvoiceUrl { get; set; }
    }
}
