using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfSmsSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfSmsSendResponse : AopResponse
    {
        /// <summary>
        /// true/false
        /// </summary>
        [XmlElement("send_status")]
        public bool SendStatus { get; set; }
    }
}
