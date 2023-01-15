using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PortraitProvinceValue Data Structure.
    /// </summary>
    [Serializable]
    public class PortraitProvinceValue : AopObject
    {
        /// <summary>
        /// 国标地区编码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 当前省辖城市数据列表
        /// </summary>
        [XmlArray("city_list")]
        [XmlArrayItem("portrait_city_value")]
        public List<PortraitCityValue> CityList { get; set; }

        /// <summary>
        /// 画像中当前省对应的人数
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 省名称，范围是我国所有省、自治区、直辖市的名称
        /// </summary>
        [XmlElement("portrait_value")]
        public string PortraitValue { get; set; }
    }
}
