using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsVoiceEventTriggerResponse.
    /// </summary>
    public class AlipayCommerceLogisticsVoiceEventTriggerResponse : AopResponse
    {
        /// <summary>
        /// 本次事件触发的唯一标识
        /// </summary>
        [XmlElement("trigger_id")]
        public string TriggerId { get; set; }
    }
}
