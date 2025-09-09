using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseInvoiceDetailQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseInvoiceDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 跟踪trace
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 发票详情
        /// </summary>
        [XmlArray("query_invoice_details")]
        [XmlArrayItem("query_invoice_detail")]
        public List<QueryInvoiceDetail> QueryInvoiceDetails { get; set; }
    }
}
