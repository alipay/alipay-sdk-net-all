using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLiveLiveroomCommentsbannedModifyResponse.
    /// </summary>
    public class AlipayContentLiveLiveroomCommentsbannedModifyResponse : AopResponse
    {
        /// <summary>
        /// 日志链路ID
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }
    }
}
