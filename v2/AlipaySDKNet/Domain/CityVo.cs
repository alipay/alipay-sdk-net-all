using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CityVo Data Structure.
    /// </summary>
    [Serializable]
    public class CityVo : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区县列表
        /// </summary>
        [XmlArray("district_list")]
        [XmlArrayItem("district_vo")]
        public List<DistrictVo> DistrictList { get; set; }
    }
}
