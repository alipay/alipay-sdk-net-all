using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtFields Data Structure.
    /// </summary>
    [Serializable]
    public class ExtFields : AopObject
    {
        /// <summary>
        /// 到达站点 ID，与 destination 对应
        /// </summary>
        [XmlElement("destination_station_id")]
        public string DestinationStationId { get; set; }

        /// <summary>
        /// 终点线路，用于匹配销售方
        /// </summary>
        [XmlElement("end_line")]
        public string EndLine { get; set; }

        /// <summary>
        /// 出发站点 ID，与 origin 对应
        /// </summary>
        [XmlElement("origin_station_id")]
        public string OriginStationId { get; set; }
    }
}
