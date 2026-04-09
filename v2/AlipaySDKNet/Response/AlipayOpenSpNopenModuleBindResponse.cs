using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNopenModuleBindResponse.
    /// </summary>
    public class AlipayOpenSpNopenModuleBindResponse : AopResponse
    {
        /// <summary>
        /// traceId信息
        /// </summary>
        [XmlElement("trace_id_info")]
        public string TraceIdInfo { get; set; }
    }
}
