using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EntranceExitObject Data Structure.
    /// </summary>
    [Serializable]
    public class EntranceExitObject : AopObject
    {
        /// <summary>
        /// 出入口唯一编码
        /// </summary>
        [XmlElement("entrance_exit_code")]
        public string EntranceExitCode { get; set; }

        /// <summary>
        /// 出入口纬度
        /// </summary>
        [XmlElement("entrance_exit_latitude")]
        public string EntranceExitLatitude { get; set; }

        /// <summary>
        /// 出入口经度
        /// </summary>
        [XmlElement("entrance_exit_longitude")]
        public string EntranceExitLongitude { get; set; }

        /// <summary>
        /// 出入口名称
        /// </summary>
        [XmlElement("entrance_exit_name")]
        public string EntranceExitName { get; set; }

        /// <summary>
        /// 地铁站点编号
        /// </summary>
        [XmlElement("metro_station_code")]
        public string MetroStationCode { get; set; }
    }
}
