using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalYpzEventSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalYpzEventSendResponse : AopResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
