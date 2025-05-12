using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfLiveCloseResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfLiveCloseResponse : AopResponse
    {
        /// <summary>
        /// 日志链路id
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }
    }
}
