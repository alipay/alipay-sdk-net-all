using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficAirticketOrderStopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficAirticketOrderStopInfo : AopObject
    {
        /// <summary>
        /// 经停机场三字码
        /// </summary>
        [XmlElement("stop_airport_code")]
        public string StopAirportCode { get; set; }

        /// <summary>
        /// 经停机场名称
        /// </summary>
        [XmlElement("stop_airport_name")]
        public string StopAirportName { get; set; }

        /// <summary>
        /// 经停降落时间
        /// </summary>
        [XmlElement("stop_arr_time")]
        public string StopArrTime { get; set; }

        /// <summary>
        /// 经停城市三字码
        /// </summary>
        [XmlElement("stop_city_code")]
        public string StopCityCode { get; set; }

        /// <summary>
        /// 经停城市名称
        /// </summary>
        [XmlElement("stop_city_name")]
        public string StopCityName { get; set; }

        /// <summary>
        /// 经停起飞时间
        /// </summary>
        [XmlElement("stop_dep_time")]
        public string StopDepTime { get; set; }

        /// <summary>
        /// 经停时间，单位秒
        /// </summary>
        [XmlElement("stop_time")]
        public long StopTime { get; set; }
    }
}
