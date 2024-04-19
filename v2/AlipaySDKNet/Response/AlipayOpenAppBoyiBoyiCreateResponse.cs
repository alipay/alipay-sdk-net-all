using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppBoyiBoyiCreateResponse.
    /// </summary>
    public class AlipayOpenAppBoyiBoyiCreateResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("esd")]
        public string Esd { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("output")]
        public string Output { get; set; }
    }
}
