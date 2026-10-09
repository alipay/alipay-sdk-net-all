using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficAirticketOrderSegmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficAirticketOrderSegmentInfo : AopObject
    {
        /// <summary>
        /// 航司二字码
        /// </summary>
        [XmlElement("ac_code")]
        public string AcCode { get; set; }

        /// <summary>
        /// 航司名称
        /// </summary>
        [XmlElement("ac_name")]
        public string AcName { get; set; }

        /// <summary>
        /// 到达机场三字码
        /// </summary>
        [XmlElement("arr_airport_code")]
        public string ArrAirportCode { get; set; }

        /// <summary>
        /// 到达机场名称
        /// </summary>
        [XmlElement("arr_airport_name")]
        public string ArrAirportName { get; set; }

        /// <summary>
        /// 到达城市三字码
        /// </summary>
        [XmlElement("arr_city_code")]
        public string ArrCityCode { get; set; }

        /// <summary>
        /// 到达城市名称
        /// </summary>
        [XmlElement("arr_city_name")]
        public string ArrCityName { get; set; }

        /// <summary>
        /// 到达航站楼
        /// </summary>
        [XmlElement("arr_terminal")]
        public string ArrTerminal { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        [XmlElement("arr_time")]
        public string ArrTime { get; set; }

        /// <summary>
        /// 舱等代码
        /// </summary>
        [XmlElement("cabin_code")]
        public string CabinCode { get; set; }

        /// <summary>
        /// 舱位名称
        /// </summary>
        [XmlElement("cabin_name")]
        public string CabinName { get; set; }

        /// <summary>
        /// 辅营商品信息
        /// </summary>
        [XmlArray("commodity_info_list")]
        [XmlArrayItem("traffic_airticket_order_commodity_info")]
        public List<TrafficAirticketOrderCommodityInfo> CommodityInfoList { get; set; }

        /// <summary>
        /// 起飞机场三字码
        /// </summary>
        [XmlElement("dep_airport_code")]
        public string DepAirportCode { get; set; }

        /// <summary>
        /// 起飞机场名称
        /// </summary>
        [XmlElement("dep_airport_name")]
        public string DepAirportName { get; set; }

        /// <summary>
        /// 起飞城市三字码
        /// </summary>
        [XmlElement("dep_city_code")]
        public string DepCityCode { get; set; }

        /// <summary>
        /// 起飞城市名称
        /// </summary>
        [XmlElement("dep_city_name")]
        public string DepCityName { get; set; }

        /// <summary>
        /// 出发航站楼
        /// </summary>
        [XmlElement("dep_terminal")]
        public string DepTerminal { get; set; }

        /// <summary>
        /// 起飞时间
        /// </summary>
        [XmlElement("dep_time")]
        public string DepTime { get; set; }

        /// <summary>
        /// 航班号
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }

        /// <summary>
        /// 餐食描述
        /// </summary>
        [XmlElement("meal")]
        public string Meal { get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        [XmlElement("plane_model")]
        public string PlaneModel { get; set; }

        /// <summary>
        /// 航段序号，按航段的起飞时间顺序编号
        /// </summary>
        [XmlElement("segment_order")]
        public long SegmentOrder { get; set; }

        /// <summary>
        /// 是否经停
        /// </summary>
        [XmlElement("stop")]
        public bool Stop { get; set; }

        /// <summary>
        /// 经停信息列表
        /// </summary>
        [XmlArray("stop_info_list")]
        [XmlArrayItem("traffic_airticket_order_stop_info")]
        public List<TrafficAirticketOrderStopInfo> StopInfoList { get; set; }

        /// <summary>
        /// 关联机票信息
        /// </summary>
        [XmlArray("ticket_info_list")]
        [XmlArrayItem("traffic_airticket_order_ticket_info")]
        public List<TrafficAirticketOrderTicketInfo> TicketInfoList { get; set; }
    }
}
