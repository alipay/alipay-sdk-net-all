using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLiveLiveroomStreamUploadResponse.
    /// </summary>
    public class AlipayContentLiveLiveroomStreamUploadResponse : AopResponse
    {
        /// <summary>
        /// 日志链路id
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }
    }
}
