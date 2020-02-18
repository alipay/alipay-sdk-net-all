using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceVerificationResultSendResponse.
    /// </summary>
    public class AlipayDataDataserviceVerificationResultSendResponse : AopResponse
    {
        /// <summary>
        /// 反馈是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
