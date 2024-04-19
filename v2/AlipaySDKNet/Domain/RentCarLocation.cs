using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarLocation Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarLocation : AopObject
    {
        /// <summary>
        /// 城市代码，以民政部2020Q1全国行政区划代码为标准，查询地址 https://www.mca.gov.cn/n156/n186/c110747/content.html 注意，四个直辖市北京上海天津重庆使用市级代码而不是省级代码，例如上海使用市级代码310100，而不是省级代码310000
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区县代码
        /// </summary>
        [XmlElement("county_code")]
        public string CountyCode { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [XmlElement("county_name")]
        public string CountyName { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 地址纬度，高德坐标系
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 地址经度，高德坐标系
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 当前地点poi名称
        /// </summary>
        [XmlElement("poi_name")]
        public string PoiName { get; set; }
    }
}
