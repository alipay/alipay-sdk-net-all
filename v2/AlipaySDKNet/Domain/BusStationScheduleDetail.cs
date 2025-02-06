using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusStationScheduleDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BusStationScheduleDetail : AopObject
    {
        /// <summary>
        /// 途径站点
        /// </summary>
        [XmlElement("station")]
        public BusStation Station { get; set; }

        /// <summary>
        /// 上车点出发时间, 使用标准"HH:mm"格式
        /// </summary>
        [XmlElement("station_time")]
        public string StationTime { get; set; }

        /// <summary>
        /// 途径站点 1. 上车点 2. 下车点
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
