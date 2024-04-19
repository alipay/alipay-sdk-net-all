using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMapGeocodingReverseResponse.
    /// </summary>
    public class AlipayEcoMapGeocodingReverseResponse : AopResponse
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
