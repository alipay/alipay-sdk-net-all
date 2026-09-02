using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusTransferObject Data Structure.
    /// </summary>
    [Serializable]
    public class BusTransferObject : AopObject
    {
        /// <summary>
        /// 公交换乘平台
        /// </summary>
        [XmlElement("bus_transfer_platform")]
        public string BusTransferPlatform { get; set; }

        /// <summary>
        /// 出入口编码
        /// </summary>
        [XmlElement("entrance_exit_code")]
        public string EntranceExitCode { get; set; }

        /// <summary>
        /// 出入口名称
        /// </summary>
        [XmlElement("entrance_exit_name")]
        public string EntranceExitName { get; set; }

        /// <summary>
        /// 地铁站点编码
        /// </summary>
        [XmlElement("metro_station_code")]
        public string MetroStationCode { get; set; }

        /// <summary>
        /// 地铁站点名称
        /// </summary>
        [XmlElement("metro_station_name")]
        public string MetroStationName { get; set; }

        /// <summary>
        /// 驻留线路数量
        /// </summary>
        [XmlElement("park_route_count")]
        public long ParkRouteCount { get; set; }

        /// <summary>
        /// 驻留线路明细，顿号隔开
        /// </summary>
        [XmlElement("park_route_detail")]
        public string ParkRouteDetail { get; set; }

        /// <summary>
        /// 站点序号
        /// </summary>
        [XmlElement("station_index")]
        public long StationIndex { get; set; }
    }
}
