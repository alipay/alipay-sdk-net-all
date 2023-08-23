using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionApplyResponse : AopResponse
    {
        /// <summary>
        /// Trace ID
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

        /// <summary>
        /// 执行耗时，单位为毫秒
        /// </summary>
        [XmlElement("cost")]
        public long Cost { get; set; }

        /// <summary>
        /// 执行云函数后返回对应函数执行结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
