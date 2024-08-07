using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BotBizInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BotBizInfo : AopObject
    {
        /// <summary>
        /// 在获取不到用户定位时，传递的兜底城市编码
        /// </summary>
        [XmlElement("actual_city_code")]
        public string ActualCityCode { get; set; }

        /// <summary>
        /// 在获取不到用户定位时，传递的兜底城市名称
        /// </summary>
        [XmlElement("actual_city_name")]
        public string ActualCityName { get; set; }

        /// <summary>
        /// 通过用户定位获取到的城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 通过用户定位获取到城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
