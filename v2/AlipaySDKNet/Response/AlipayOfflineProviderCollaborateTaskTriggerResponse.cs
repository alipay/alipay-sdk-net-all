using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateTaskTriggerResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateTaskTriggerResponse : AopResponse
    {
        /// <summary>
        /// 代表一次呼叫的唯一id
        /// </summary>
        [XmlElement("call_id")]
        public string CallId { get; set; }
    }
}
