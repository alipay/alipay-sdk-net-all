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

        /// <summary>
        /// true:允许变更呼叫方式，允许服务商在意图确认接口，通过反馈UN_ANSWERED拿到商户具体的联系方式。 false:默认值
        /// </summary>
        [XmlElement("call_transfer")]
        public bool CallTransfer { get; set; }
    }
}
