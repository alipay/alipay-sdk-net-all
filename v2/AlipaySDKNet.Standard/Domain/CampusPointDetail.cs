using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CampusPointDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CampusPointDetail : AopObject
    {
        /// <summary>
        /// 校区详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 校区围栏唯一编码
        /// </summary>
        [XmlElement("aoi_id")]
        public string AoiId { get; set; }

        /// <summary>
        /// 校区ID
        /// </summary>
        [XmlElement("campus_id")]
        public string CampusId { get; set; }

        /// <summary>
        /// 校区名称
        /// </summary>
        [XmlElement("campus_name")]
        public string CampusName { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 当前入参的经纬度与当前校区中心点位的距离，单位米
        /// </summary>
        [XmlElement("dist")]
        public string Dist { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 区县编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 学校ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 省份中文名称
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
