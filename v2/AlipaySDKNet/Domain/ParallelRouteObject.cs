using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParallelRouteObject Data Structure.
    /// </summary>
    [Serializable]
    public class ParallelRouteObject : AopObject
    {
        /// <summary>
        /// 公交线路名称
        /// </summary>
        [XmlElement("bus_route_name")]
        public string BusRouteName { get; set; }

        /// <summary>
        /// 重复车站数量
        /// </summary>
        [XmlElement("repeat_station_count")]
        public long RepeatStationCount { get; set; }

        /// <summary>
        /// 重复车站明细
        /// </summary>
        [XmlElement("repeat_station_detail")]
        public string RepeatStationDetail { get; set; }

        /// <summary>
        /// 站点序号
        /// </summary>
        [XmlElement("station_index")]
        public long StationIndex { get; set; }
    }
}
