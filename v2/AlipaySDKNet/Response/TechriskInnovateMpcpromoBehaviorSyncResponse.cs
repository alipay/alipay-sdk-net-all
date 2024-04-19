using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoBehaviorSyncResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoBehaviorSyncResponse : AopResponse
    {
        /// <summary>
        /// 请求的traceid，用于排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
