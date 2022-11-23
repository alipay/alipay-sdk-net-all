using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppTestGrayModifyResponse.
    /// </summary>
    public class AlipayOpenAppTestGrayModifyResponse : AopResponse
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// zone
        /// </summary>
        [XmlElement("zone_name")]
        public string ZoneName { get; set; }
    }
}
