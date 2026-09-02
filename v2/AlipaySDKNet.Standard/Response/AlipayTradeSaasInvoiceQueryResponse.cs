using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasInvoiceQueryResponse.
    /// </summary>
    public class AlipayTradeSaasInvoiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票详细信息
        /// </summary>
        [XmlElement("invoice_detail_info")]
        public InvoiceDetailInfo InvoiceDetailInfo { get; set; }
    }
}
