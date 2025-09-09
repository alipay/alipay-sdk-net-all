using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCtocOperationOnlineResponse.
    /// </summary>
    public class AnttechNftCtocOperationOnlineResponse : AopResponse
    {
        /// <summary>
        /// 认证事件ID
        /// </summary>
        [XmlElement("verify_event_id")]
        public string VerifyEventId { get; set; }
    }
}
