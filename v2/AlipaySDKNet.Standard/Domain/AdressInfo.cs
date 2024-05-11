using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AdressInfo : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 地区编码
        /// </summary>
        [XmlElement("district_id")]
        public string DistrictId { get; set; }

        /// <summary>
        /// 对应高德地图的POI ID
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_id")]
        public string ProvinceId { get; set; }
    }
}
