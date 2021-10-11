using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SchoolInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SchoolInfo : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 外标
        /// </summary>
        [XmlElement("inst_std_code")]
        public string InstStdCode { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 学校属性
        /// </summary>
        [XmlElement("school_property")]
        public string SchoolProperty { get; set; }
    }
}
