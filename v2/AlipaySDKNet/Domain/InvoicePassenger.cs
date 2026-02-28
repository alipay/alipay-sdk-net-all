using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoicePassenger Data Structure.
    /// </summary>
    [Serializable]
    public class InvoicePassenger : AopObject
    {
        /// <summary>
        /// 出行人身份证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 出发地
        /// </summary>
        [XmlElement("departure")]
        public string Departure { get; set; }

        /// <summary>
        /// 到达地
        /// </summary>
        [XmlElement("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 出行人姓名
        /// </summary>
        [XmlElement("passenger_name")]
        public string PassengerName { get; set; }

        /// <summary>
        /// 交通工具为 火车时: 一等座 二等座 软席(软座、 软卧) 硬席(硬座、 硬卧) 交通工作为 飞机时: 公务舱 头等舱 经济舱 交通工具为 船舶(不包括 旅游船) 时: 一等舱 二等舱 三等舱
        /// </summary>
        [XmlElement("seat_class")]
        public string SeatClass { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 出行日期,时间格式以实际返回为主
        /// </summary>
        [XmlElement("travel_date")]
        public string TravelDate { get; set; }

        /// <summary>
        /// 交通方式
        /// </summary>
        [XmlElement("travel_method")]
        public string TravelMethod { get; set; }
    }
}
