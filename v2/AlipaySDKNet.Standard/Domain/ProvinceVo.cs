using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProvinceVo Data Structure.
    /// </summary>
    [Serializable]
    public class ProvinceVo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("city_list")]
        [XmlArrayItem("city_vo")]
        public List<CityVo> CityList { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 身份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }
    }
}
