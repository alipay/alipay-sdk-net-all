using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedfollowupBadgeNotifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedfollowupBadgeNotifyResponse : AopResponse
    {
        /// <summary>
        /// 通知
        /// </summary>
        [XmlElement("notify")]
        public string Notify { get; set; }
    }
}
