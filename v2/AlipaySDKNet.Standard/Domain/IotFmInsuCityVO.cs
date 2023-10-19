using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotFmInsuCityVO Data Structure.
    /// </summary>
    [Serializable]
    public class IotFmInsuCityVO : AopObject
    {
        /// <summary>
        /// 参保城市编码国标
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 参保地城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 参保地城市编码机构
        /// </summary>
        [XmlElement("ins_city_code")]
        public string InsCityCode { get; set; }
    }
}
