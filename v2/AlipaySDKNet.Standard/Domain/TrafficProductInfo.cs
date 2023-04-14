using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficProductInfo : AopObject
    {
        /// <summary>
        /// 出发地名称，对于BUS类型该字段必填。
        /// </summary>
        [XmlElement("departure")]
        public string Departure { get; set; }

        /// <summary>
        /// 乘车点、出发口
        /// </summary>
        [XmlElement("departure_gate")]
        public string DepartureGate { get; set; }

        /// <summary>
        /// 到达地，对于BUS类型必传。
        /// </summary>
        [XmlElement("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public ScenicExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 出发地纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 出发地经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 路线名称。
        /// </summary>
        [XmlElement("route_name")]
        public string RouteName { get; set; }

        /// <summary>
        /// isv侧唯一标识该小交通路线的key。
        /// </summary>
        [XmlElement("route_no")]
        public string RouteNo { get; set; }

        /// <summary>
        /// 座位类型
        /// </summary>
        [XmlElement("seat_type")]
        public string SeatType { get; set; }

        /// <summary>
        /// 车牌号，对于BUS类型必填。
        /// </summary>
        [XmlElement("traffic_no")]
        public string TrafficNo { get; set; }

        /// <summary>
        /// 交通类型
        /// </summary>
        [XmlElement("traffic_type")]
        public string TrafficType { get; set; }
    }
}
