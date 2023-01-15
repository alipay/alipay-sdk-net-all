using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApprovalItinerary Data Structure.
    /// </summary>
    [Serializable]
    public class ApprovalItinerary : AopObject
    {
        /// <summary>
        /// 到达城市
        /// </summary>
        [XmlElement("arr_city")]
        public string ArrCity { get; set; }

        /// <summary>
        /// 成都市
        /// </summary>
        [XmlElement("arr_city_code")]
        public string ArrCityCode { get; set; }

        /// <summary>
        /// 出发城市
        /// </summary>
        [XmlElement("dep_city")]
        public string DepCity { get; set; }

        /// <summary>
        /// 出发城市编码
        /// </summary>
        [XmlElement("dep_city_code")]
        public string DepCityCode { get; set; }

        /// <summary>
        /// 行程结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 行程单ID
        /// </summary>
        [XmlElement("itinerary_id")]
        public string ItineraryId { get; set; }

        /// <summary>
        /// 行程开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 交通方式
        /// </summary>
        [XmlElement("traffic_type")]
        public string TrafficType { get; set; }

        /// <summary>
        /// 行程类型
        /// </summary>
        [XmlElement("trip_way")]
        public string TripWay { get; set; }
    }
}
