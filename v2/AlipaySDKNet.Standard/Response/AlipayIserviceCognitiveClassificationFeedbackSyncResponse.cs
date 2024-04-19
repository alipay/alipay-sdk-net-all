using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationFeedbackSyncResponse.
    /// </summary>
    public class AlipayIserviceCognitiveClassificationFeedbackSyncResponse : AopResponse
    {
        /// <summary>
        /// 错误code
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 接口返回
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// trace_id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
