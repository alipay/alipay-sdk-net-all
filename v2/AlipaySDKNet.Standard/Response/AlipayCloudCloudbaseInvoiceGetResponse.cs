using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseInvoiceGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseInvoiceGetResponse : AopResponse
    {
        /// <summary>
        /// 开票记录uuid
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 跟踪trace
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

        /// <summary>
        /// 预览发票数据
        /// </summary>
        [XmlArray("invoice_datas")]
        [XmlArrayItem("pre_invoice_data")]
        public List<PreInvoiceData> InvoiceDatas { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
