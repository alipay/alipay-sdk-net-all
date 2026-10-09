using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AreaAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AreaAddressInfo : AopObject
    {
        /// <summary>
        /// 小区所在的详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 小区所在的城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 小区所在区县对应的编码
        /// </summary>
        [XmlElement("county_code")]
        public string CountyCode { get; set; }

        /// <summary>
        /// 小区地址对应的高德PoiId
        /// </summary>
        [XmlElement("gaode_poi_id")]
        public string GaodePoiId { get; set; }

        /// <summary>
        /// 小区地址的纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 小区地址的经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 小区所在的省份/直辖市对应的编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
