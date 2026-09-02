using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleStationVO Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleStationVO : AopObject
    {
        /// <summary>
        /// 列车预计到达该站的时间，单位：秒。当前站点为 0 表示列车已到站/即将到站。
        /// </summary>
        [XmlElement("est_time_in_sec")]
        public long EstTimeInSec { get; set; }

        /// <summary>
        /// 站点中文名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 站点在线路上的序号（字符串形式）。
        /// </summary>
        [XmlElement("order")]
        public string Order { get; set; }

        /// <summary>
        /// 站点编码
        /// </summary>
        [XmlElement("station_code")]
        public string StationCode { get; set; }

        /// <summary>
        /// 列车在该站的停靠时刻，格式为 hh:mm
        /// </summary>
        [XmlElement("train_stop_time")]
        public string TrainStopTime { get; set; }
    }
}
