using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseInvoiceStatusQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseInvoiceStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 跟踪trace
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

        /// <summary>
        /// 发票信息
        /// </summary>
        [XmlElement("invoice_data")]
        public InvoiceData InvoiceData { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
