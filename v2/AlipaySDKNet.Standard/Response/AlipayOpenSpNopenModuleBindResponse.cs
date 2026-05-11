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
        /// 模组SN
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// traceId信息
        /// </summary>
        [XmlElement("trace_id_info")]
        public string TraceIdInfo { get; set; }

        /// <summary>
        /// N链接URL
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
