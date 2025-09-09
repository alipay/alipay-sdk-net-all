using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialGamecenterGamerightsConsultResponse.
    /// </summary>
    public class AlipaySocialGamecenterGamerightsConsultResponse : AopResponse
    {
        /// <summary>
        /// 不可触发权益原因
        /// </summary>
        [XmlElement("can_not_trigger_reason")]
        public string CanNotTriggerReason { get; set; }

        /// <summary>
        /// 可以发放为 true，不可发放为false。
        /// </summary>
        [XmlElement("can_trigger")]
        public bool CanTrigger { get; set; }
    }
}
