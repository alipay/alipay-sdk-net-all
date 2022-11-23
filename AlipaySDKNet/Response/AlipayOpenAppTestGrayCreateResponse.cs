using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppTestGrayCreateResponse.
    /// </summary>
    public class AlipayOpenAppTestGrayCreateResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("zone_name")]
        public string ZoneName { get; set; }
    }
}
