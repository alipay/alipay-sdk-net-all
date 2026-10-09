using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseInvoiceBalanceQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseInvoiceBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 跟踪trace
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

        /// <summary>
        /// 可开票金额信息
        /// </summary>
        [XmlElement("invoice_amount_info")]
        public InvoiceAmountInfo InvoiceAmountInfo { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
