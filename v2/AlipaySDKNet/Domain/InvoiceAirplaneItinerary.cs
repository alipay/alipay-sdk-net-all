using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceAirplaneItinerary Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceAirplaneItinerary : AopObject
    {
        /// <summary>
        /// 免费行李
        /// </summary>
        [XmlElement("baggage")]
        public string Baggage { get; set; }

        /// <summary>
        /// 承运人
        /// </summary>
        [XmlElement("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// 出发地
        /// </summary>
        [XmlElement("departure")]
        public string Departure { get; set; }

        /// <summary>
        /// 出发日期，时间格式以实际返回为主
        /// </summary>
        [XmlElement("departure_date")]
        public string DepartureDate { get; set; }

        /// <summary>
        /// 出发时间，时间格式以实际返回为主
        /// </summary>
        [XmlElement("departure_time")]
        public string DepartureTime { get; set; }

        /// <summary>
        /// 到达地
        /// </summary>
        [XmlElement("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 客票有效截止日期，时间格式以实际返回为主
        /// </summary>
        [XmlElement("expiry_date")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 航班号
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }

        /// <summary>
        /// 客票类别
        /// </summary>
        [XmlElement("passenger_class")]
        public string PassengerClass { get; set; }

        /// <summary>
        /// 座位等级
        /// </summary>
        [XmlElement("seat_class")]
        public string SeatClass { get; set; }

        /// <summary>
        /// 客票生效日期，时间格式以实际返回为主
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
