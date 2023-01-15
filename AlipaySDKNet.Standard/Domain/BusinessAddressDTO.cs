using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessAddressDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessAddressDTO : AopObject
    {
        /// <summary>
        /// 所在地市（代码）
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 所在国家（代码）
        /// </summary>
        [XmlElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 区代码（代码）
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 所在地省（代码）
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 街道(乡镇)代码
        /// </summary>
        [XmlElement("town_code")]
        public string TownCode { get; set; }
    }
}
