using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelPartnerTriggerResponse.
    /// </summary>
    public class AlipayCloudCloudpromoTravelPartnerTriggerResponse : AopResponse
    {
        /// <summary>
        /// 伴游状态，WAITING、OPEN、CLOSE
        /// </summary>
        [XmlElement("assist_status")]
        public string AssistStatus { get; set; }
    }
}
