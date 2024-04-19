using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StopInfo : AopObject
    {
        /// <summary>
        /// 经停机场三字码
        /// </summary>
        [XmlElement("stop_airport")]
        public string StopAirport { get; set; }

        /// <summary>
        /// 经停机场名称
        /// </summary>
        [XmlElement("stop_airport_name")]
        public string StopAirportName { get; set; }

        /// <summary>
        /// 经停城市三字码
        /// </summary>
        [XmlElement("stop_city")]
        public string StopCity { get; set; }

        /// <summary>
        /// 经停城市名称
        /// </summary>
        [XmlElement("stop_city_name")]
        public string StopCityName { get; set; }

        /// <summary>
        /// 经停时长，单位：s
        /// </summary>
        [XmlElement("stop_time")]
        public long StopTime { get; set; }
    }
}
