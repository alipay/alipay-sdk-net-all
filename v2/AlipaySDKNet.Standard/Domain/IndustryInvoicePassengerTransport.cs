using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInvoicePassengerTransport Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInvoicePassengerTransport : AopObject
    {
        /// <summary>
        /// 旅客出发地
        /// </summary>
        [XmlElement("departure")]
        public string Departure { get; set; }

        /// <summary>
        /// 旅客到达地
        /// </summary>
        [XmlElement("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 有效身份证件号
        /// </summary>
        [XmlElement("passenger_cert_no")]
        public string PassengerCertNo { get; set; }

        /// <summary>
        /// 见枚举IndustryPassengerCertTypeEnum
        /// </summary>
        [XmlElement("passenger_cert_type")]
        public string PassengerCertType { get; set; }

        /// <summary>
        /// 乘客姓名
        /// </summary>
        [XmlElement("passenger_name")]
        public string PassengerName { get; set; }

        /// <summary>
        /// 当交通工具类型为飞机(AIR)/火车(TRAIN)/船舶(SHIP)时必填，交通工具为火车时可填：一等座，二等座，软席（软座、软卧），硬席（硬座、硬卧）； 交通工具为飞机时可填：公务舱，头等舱，经济舱； 交通工具为船舶 （不包括旅游船）时可填：一等舱，二等舱，三等舱； 其他交通工具可自定义座椅等级描述，不需要标注座椅等级时可填”无“；
        /// </summary>
        [XmlElement("seat_class")]
        public string SeatClass { get; set; }

        /// <summary>
        /// 从1开始，票面上支持多行按顺序渲染
        /// </summary>
        [XmlElement("serial_no")]
        public long SerialNo { get; set; }

        /// <summary>
        /// 格式必须是"yyyy-MM-dd"
        /// </summary>
        [XmlElement("travel_date")]
        public string TravelDate { get; set; }

        /// <summary>
        /// 交通工具类型，目前仅支持出租车类型
        /// </summary>
        [XmlElement("travel_method")]
        public string TravelMethod { get; set; }
    }
}
