using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StationLine Data Structure.
    /// </summary>
    [Serializable]
    public class StationLine : AopObject
    {
        /// <summary>
        /// 实时公交到站信息
        /// </summary>
        [XmlElement("buses")]
        public BusRealtimeInfo Buses { get; set; }

        /// <summary>
        /// 终点站
        /// </summary>
        [XmlElement("end_stop")]
        public string EndStop { get; set; }

        /// <summary>
        /// 首班车时间。格式为HH:MM
        /// </summary>
        [XmlElement("first_bus")]
        public string FirstBus { get; set; }

        /// <summary>
        /// 发车间隔。单位是分钟
        /// </summary>
        [XmlElement("interval")]
        public long Interval { get; set; }

        /// <summary>
        /// 末班车时间。格式为HH:MM
        /// </summary>
        [XmlElement("last_bus")]
        public string LastBus { get; set; }

        /// <summary>
        /// 详情详情跳转链接。支付宝小程序内部可以跳转到这个链接对应的页面
        /// </summary>
        [XmlElement("line_detail_schema")]
        public string LineDetailSchema { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路名称
        /// </summary>
        [XmlElement("line_name")]
        public string LineName { get; set; }

        /// <summary>
        /// 是否支持实时公交到站信息。true支持，false 不支持
        /// </summary>
        [XmlElement("real_time")]
        public bool RealTime { get; set; }

        /// <summary>
        /// 起点站
        /// </summary>
        [XmlElement("start_stop")]
        public string StartStop { get; set; }

        /// <summary>
        /// 站点id，站点的唯一标志
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }
    }
}
