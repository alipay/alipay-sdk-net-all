using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTrainItinerary Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTrainItinerary : AopObject
    {
        /// <summary>
        /// 出发站
        /// </summary>
        [XmlElement("departure")]
        public string Departure { get; set; }

        /// <summary>
        /// 出发时间，时间格式以实际返回为主
        /// </summary>
        [XmlElement("departure_time")]
        public string DepartureTime { get; set; }

        /// <summary>
        /// 到达站
        /// </summary>
        [XmlElement("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 座位等级
        /// </summary>
        [XmlElement("seat_class")]
        public string SeatClass { get; set; }

        /// <summary>
        /// 座位号
        /// </summary>
        [XmlElement("seat_no")]
        public string SeatNo { get; set; }

        /// <summary>
        /// 列车号
        /// </summary>
        [XmlElement("train_no")]
        public string TrainNo { get; set; }
    }
}
