using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SchoolBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SchoolBaseInfo : AopObject
    {
        /// <summary>
        /// 校区信息
        /// </summary>
        [XmlArray("campus_info")]
        [XmlArrayItem("campus_info")]
        public List<CampusInfo> CampusInfo { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("inst_std_code")]
        public string InstStdCode { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
