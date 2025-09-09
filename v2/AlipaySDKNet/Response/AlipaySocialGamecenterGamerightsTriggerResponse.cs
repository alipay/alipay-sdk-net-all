using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialGamecenterGamerightsTriggerResponse.
    /// </summary>
    public class AlipaySocialGamecenterGamerightsTriggerResponse : AopResponse
    {
        /// <summary>
        /// 不可触发权益原因
        /// </summary>
        [XmlElement("can_not_trigger_reason")]
        public string CanNotTriggerReason { get; set; }

        /// <summary>
        /// 发放为 true，未发放为false。
        /// </summary>
        [XmlElement("trigger_success")]
        public bool TriggerSuccess { get; set; }
    }
}
