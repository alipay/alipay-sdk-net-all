using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMallEventSendResponse.
    /// </summary>
    public class KoubeiMallEventSendResponse : AopResponse
    {
        /// <summary>
        /// 事件ID
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }
    }
}
