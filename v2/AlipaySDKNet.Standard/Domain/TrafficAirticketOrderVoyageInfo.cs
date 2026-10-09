using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficAirticketOrderVoyageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficAirticketOrderVoyageInfo : AopObject
    {
        /// <summary>
        /// 辅营商品信息
        /// </summary>
        [XmlArray("commodity_info_list")]
        [XmlArrayItem("traffic_airticket_order_commodity_info")]
        public List<TrafficAirticketOrderCommodityInfo> CommodityInfoList { get; set; }

        /// <summary>
        /// 航程结束机场三字码
        /// </summary>
        [XmlElement("end_airport_code")]
        public string EndAirportCode { get; set; }

        /// <summary>
        /// 航程结束机场名称
        /// </summary>
        [XmlElement("end_airport_name")]
        public string EndAirportName { get; set; }

        /// <summary>
        /// 航程结束城市三字码
        /// </summary>
        [XmlElement("end_city_code")]
        public string EndCityCode { get; set; }

        /// <summary>
        /// 航程结束城市名称
        /// </summary>
        [XmlElement("end_city_name")]
        public string EndCityName { get; set; }

        /// <summary>
        /// 航程结束时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否国际航程 1. true-是国际航程 2. false-不是国际航程（仅国内）
        /// </summary>
        [XmlElement("international")]
        public bool International { get; set; }

        /// <summary>
        /// 航段信息
        /// </summary>
        [XmlArray("segment_info_list")]
        [XmlArrayItem("traffic_airticket_order_segment_info")]
        public List<TrafficAirticketOrderSegmentInfo> SegmentInfoList { get; set; }

        /// <summary>
        /// 航程开始机场三字码
        /// </summary>
        [XmlElement("start_airport_code")]
        public string StartAirportCode { get; set; }

        /// <summary>
        /// 航程开始机场名称
        /// </summary>
        [XmlElement("start_airport_name")]
        public string StartAirportName { get; set; }

        /// <summary>
        /// 航程开始城市三字码
        /// </summary>
        [XmlElement("start_city_code")]
        public string StartCityCode { get; set; }

        /// <summary>
        /// 航程开始城市名称
        /// </summary>
        [XmlElement("start_city_name")]
        public string StartCityName { get; set; }

        /// <summary>
        /// 航程开始时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 是否中转 1. true-是中转 2. false-不是中转
        /// </summary>
        [XmlElement("transfer")]
        public bool Transfer { get; set; }

        /// <summary>
        /// 航程序号，按航程的起飞时间顺序编号
        /// </summary>
        [XmlElement("voyage_order")]
        public long VoyageOrder { get; set; }
    }
}
