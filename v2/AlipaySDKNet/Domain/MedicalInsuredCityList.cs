using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalInsuredCityList Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalInsuredCityList : AopObject
    {
        /// <summary>
        /// 参保地城市编码(国标)
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 参保地城市编码(机构)
        /// </summary>
        [XmlElement("ins_city_code")]
        public string InsCityCode { get; set; }

        /// <summary>
        /// 参保地城市名称(机构)
        /// </summary>
        [XmlElement("ins_city_name")]
        public string InsCityName { get; set; }

        /// <summary>
        /// 是否是默认参保地
        /// </summary>
        [XmlElement("is_default_city")]
        public string IsDefaultCity { get; set; }
    }
}
