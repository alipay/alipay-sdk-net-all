using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseInvoiceApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseInvoiceApplyResponse : AopResponse
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
        /// 消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
