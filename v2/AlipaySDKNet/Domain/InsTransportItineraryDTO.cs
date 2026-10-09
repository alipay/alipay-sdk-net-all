using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsTransportItineraryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsTransportItineraryDTO : AopObject
    {
        /// <summary>
        /// 到达具体地址
        /// </summary>
        [XmlElement("end_address")]
        public string EndAddress { get; set; }

        /// <summary>
        /// 到达城市
        /// </summary>
        [XmlElement("end_city")]
        public string EndCity { get; set; }

        /// <summary>
        /// 到达站
        /// </summary>
        [XmlElement("end_station")]
        public string EndStation { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 行程订单号
        /// </summary>
        [XmlElement("itinerary_order_no")]
        public string ItineraryOrderNo { get; set; }

        /// <summary>
        /// 乘客
        /// </summary>
        [XmlElement("passenger")]
        public InsOpenUserDTO Passenger { get; set; }

        /// <summary>
        /// 行程序号
        /// </summary>
        [XmlElement("seq")]
        public long Seq { get; set; }

        /// <summary>
        /// 出发地址
        /// </summary>
        [XmlElement("start_address")]
        public string StartAddress { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("start_city")]
        public string StartCity { get; set; }

        /// <summary>
        /// 出发站
        /// </summary>
        [XmlElement("start_station")]
        public string StartStation { get; set; }

        /// <summary>
        /// 出发时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 交通类型
        /// </summary>
        [XmlElement("transport_mode")]
        public string TransportMode { get; set; }

        /// <summary>
        /// 班次号
        /// </summary>
        [XmlElement("transport_no")]
        public string TransportNo { get; set; }
    }
}
