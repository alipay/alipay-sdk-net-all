using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayCodecQrcodecacheAddResponse.
    /// </summary>
    public class AlipayPayCodecQrcodecacheAddResponse : AopResponse
    {
        /// <summary>
        /// true或者false
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
