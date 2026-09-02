using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfMsgSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfMsgSyncResponse : AopResponse
    {
        /// <summary>
        /// true/false
        /// </summary>
        [XmlElement("send_status")]
        public bool SendStatus { get; set; }
    }
}
