using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfPushSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfPushSyncResponse : AopResponse
    {
        /// <summary>
        /// true/false
        /// </summary>
        [XmlElement("send_status")]
        public bool SendStatus { get; set; }
    }
}
