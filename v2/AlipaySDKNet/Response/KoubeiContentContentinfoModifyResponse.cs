using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiContentContentinfoModifyResponse.
    /// </summary>
    public class KoubeiContentContentinfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 内容id
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 全链路Id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
