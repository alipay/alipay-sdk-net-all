using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EffectBusRouteObject Data Structure.
    /// </summary>
    [Serializable]
    public class EffectBusRouteObject : AopObject
    {
        /// <summary>
        /// 变化比例
        /// </summary>
        [XmlElement("change_ratio")]
        public string ChangeRatio { get; set; }

        /// <summary>
        /// 日均客流，单位：人次
        /// </summary>
        [XmlElement("daily_passenger_flow")]
        public string DailyPassengerFlow { get; set; }

        /// <summary>
        /// 下行方向
        /// </summary>
        [XmlElement("down_direction")]
        public string DownDirection { get; set; }

        /// <summary>
        /// 下行客流下降站点信息
        /// </summary>
        [XmlElement("down_passenger_drop_station")]
        public string DownPassengerDropStation { get; set; }

        /// <summary>
        /// 客流变化量。单位：人
        /// </summary>
        [XmlElement("passenger_delta")]
        public string PassengerDelta { get; set; }

        /// <summary>
        /// 排名
        /// </summary>
        [XmlElement("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// 线路信息
        /// </summary>
        [XmlElement("route_information")]
        public string RouteInformation { get; set; }

        /// <summary>
        /// 线路名称
        /// </summary>
        [XmlElement("route_name")]
        public string RouteName { get; set; }

        /// <summary>
        /// 线路重复情况
        /// </summary>
        [XmlElement("route_repeat")]
        public string RouteRepeat { get; set; }

        /// <summary>
        /// 趋势类型
        /// </summary>
        [XmlElement("trend_type")]
        public string TrendType { get; set; }

        /// <summary>
        /// 上行方向
        /// </summary>
        [XmlElement("up_direction")]
        public string UpDirection { get; set; }

        /// <summary>
        /// 上行客流下降站点
        /// </summary>
        [XmlElement("up_passenger_drop_station")]
        public string UpPassengerDropStation { get; set; }
    }
}
