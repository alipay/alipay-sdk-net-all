using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficAirticketOrderTicketInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficAirticketOrderTicketInfo : AopObject
    {
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
        /// 到达时间
        /// </summary>
        [XmlElement("arr_time")]
        public string ArrTime { get; set; }

        /// <summary>
        /// 辅营商品信息
        /// </summary>
        [XmlArray("commodity_info_list")]
        [XmlArrayItem("traffic_airticket_order_commodity_info")]
        public List<TrafficAirticketOrderCommodityInfo> CommodityInfoList { get; set; }

        /// <summary>
        /// 出发机场三字码
        /// </summary>
        [XmlElement("dep_airport_code")]
        public string DepAirportCode { get; set; }

        /// <summary>
        /// 出发机场名称
        /// </summary>
        [XmlElement("dep_airport_name")]
        public string DepAirportName { get; set; }

        /// <summary>
        /// 出发城市三字码
        /// </summary>
        [XmlElement("dep_city_code")]
        public string DepCityCode { get; set; }

        /// <summary>
        /// 出发城市名称
        /// </summary>
        [XmlElement("dep_city_name")]
        public string DepCityName { get; set; }

        /// <summary>
        /// 出发时间
        /// </summary>
        [XmlElement("dep_time")]
        public string DepTime { get; set; }

        /// <summary>
        /// 是否国际航班票 1. true-该票是国际航班票 2. false-该票不是国际航班票
        /// </summary>
        [XmlElement("international")]
        public bool International { get; set; }

        /// <summary>
        /// 该机票状态变更前关联的机票唯一标识，如：机票改签前旧票的uuid
        /// </summary>
        [XmlElement("ori_ticket_uuid")]
        public string OriTicketUuid { get; set; }

        /// <summary>
        /// 是否共享航班 1. true-该航班是共享航班 2. false-该航班不是共享航班
        /// </summary>
        [XmlElement("share")]
        public bool Share { get; set; }

        /// <summary>
        /// 共享航班信息
        /// </summary>
        [XmlElement("share_info")]
        public TrafficAirticketOrderShareInfo ShareInfo { get; set; }

        /// <summary>
        /// 机票状态code
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 机票状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 机票号
        /// </summary>
        [XmlElement("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 机票序号，按机票的起飞时间顺序编号
        /// </summary>
        [XmlElement("ticket_order")]
        public long TicketOrder { get; set; }

        /// <summary>
        /// 机票类型
        /// </summary>
        [XmlElement("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 由商家生成的机票唯一标识
        /// </summary>
        [XmlElement("ticket_uuid")]
        public string TicketUuid { get; set; }
    }
}
