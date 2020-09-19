using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceAddressQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceAddressQueryResponse : AopResponse
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 国家信息
        /// </summary>
        [XmlElement("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// 县/区名称
        /// </summary>
        [XmlElement("county_name")]
        public string CountyName { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 街道名称
        /// </summary>
        [XmlElement("town_name")]
        public string TownName { get; set; }
    }
}
