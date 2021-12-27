using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockMessageSendResponse.
    /// </summary>
    public class AntfortuneStockMessageSendResponse : AopResponse
    {
        /// <summary>
        /// 用户未签约
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// traceId、用来唯一定位某次调用，方便问题排查
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
