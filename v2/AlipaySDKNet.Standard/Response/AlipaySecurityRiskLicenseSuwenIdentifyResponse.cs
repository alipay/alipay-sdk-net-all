using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskLicenseSuwenIdentifyResponse.
    /// </summary>
    public class AlipaySecurityRiskLicenseSuwenIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 素问工单id
        /// </summary>
        [XmlElement("suwen_event_id")]
        public string SuwenEventId { get; set; }
    }
}
