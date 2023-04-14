using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMapdistributionQueryResponse.
    /// </summary>
    public class AlipayDataMdaMapdistributionQueryResponse : AopResponse
    {
        /// <summary>
        /// 中国34个省293个地级市用户数
        /// </summary>
        [XmlElement("city_uv")]
        public string CityUv { get; set; }

        /// <summary>
        /// 亚洲48个国家用户数
        /// </summary>
        [XmlElement("country_uv")]
        public string CountryUv { get; set; }
    }
}
