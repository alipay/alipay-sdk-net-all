using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportHotelMinpriceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportHotelMinpriceQueryModel : AopObject
    {
        /// <summary>
        /// 入住日期，格式为：yyyy-MM-dd
        /// </summary>
        [XmlElement("arrival_date")]
        public string ArrivalDate { get; set; }

        /// <summary>
        /// 离店日期，格式为：yyyy-MM-dd
        /// </summary>
        [XmlElement("departure_date")]
        public string DepartureDate { get; set; }

        /// <summary>
        /// 支付宝聚合酒店id,数字
        /// </summary>
        [XmlElement("hotel_id")]
        public string HotelId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 控制查询结果返回节点，用英文“,”分割
        /// </summary>
        [XmlElement("options")]
        public string Options { get; set; }

        /// <summary>
        /// 支付宝聚合房型id，数字，不为空时，返回该房型的最小价
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
