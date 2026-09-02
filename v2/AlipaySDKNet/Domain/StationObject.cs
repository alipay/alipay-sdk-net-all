using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StationObject Data Structure.
    /// </summary>
    [Serializable]
    public class StationObject : AopObject
    {
        /// <summary>
        /// 站点唯一编码
        /// </summary>
        [XmlElement("metro_station_code")]
        public string MetroStationCode { get; set; }

        /// <summary>
        /// 地铁站点纬度
        /// </summary>
        [XmlElement("metro_station_latitude")]
        public string MetroStationLatitude { get; set; }

        /// <summary>
        /// 地铁站点经度
        /// </summary>
        [XmlElement("metro_station_longitude")]
        public string MetroStationLongitude { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("metro_station_name")]
        public string MetroStationName { get; set; }
    }
}
