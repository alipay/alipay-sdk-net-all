using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApeselectSyncResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApeselectSyncResponse : AopResponse
    {
        /// <summary>
        /// 请求链路标识，用于排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
