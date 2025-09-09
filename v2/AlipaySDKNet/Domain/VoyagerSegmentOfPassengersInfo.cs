using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerSegmentOfPassengersInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerSegmentOfPassengersInfo : AopObject
    {
        /// <summary>
        /// 三字码，例如：PEK
        /// </summary>
        [XmlElement("arrive_airport_code")]
        public string ArriveAirportCode { get; set; }

        /// <summary>
        /// 三字码，例如：TPE
        /// </summary>
        [XmlElement("arrive_city_code")]
        public string ArriveCityCode { get; set; }

        /// <summary>
        /// 到达航站楼
        /// </summary>
        [XmlElement("arrive_terminal")]
        public string ArriveTerminal { get; set; }

        /// <summary>
        /// 到达时间 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("arrive_time")]
        public string ArriveTime { get; set; }

        /// <summary>
        /// 舱等 Y:经济舱 S:超级经济舱 C:公务舱 F:头等舱 UNKOWN:未知
        /// </summary>
        [XmlElement("cabin_class_code")]
        public string CabinClassCode { get; set; }

        /// <summary>
        /// 三字码，例如：PEK
        /// </summary>
        [XmlElement("depart_airport_code")]
        public string DepartAirportCode { get; set; }

        /// <summary>
        /// 三字码，例如：TPE
        /// </summary>
        [XmlElement("depart_city_code")]
        public string DepartCityCode { get; set; }

        /// <summary>
        /// 出发日期 格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("depart_date")]
        public string DepartDate { get; set; }

        /// <summary>
        /// 出发航站楼
        /// </summary>
        [XmlElement("depart_terminal")]
        public string DepartTerminal { get; set; }

        /// <summary>
        /// 出发时间 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("depart_time")]
        public string DepartTime { get; set; }

        /// <summary>
        /// FLIGHT_CHANGE(航变), FLIGHT_CANCEL(取消), REFUND(退票), ORDER_CHANGE(改签)
        /// </summary>
        [XmlElement("expire_reason")]
        public string ExpireReason { get; set; }

        /// <summary>
        /// 飞行时长(单位毫秒)
        /// </summary>
        [XmlElement("flight_duration")]
        public long FlightDuration { get; set; }

        /// <summary>
        /// 航班号
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }

        /// <summary>
        /// 当前航段属于第几个行程（行程的顺序），从0开始
        /// </summary>
        [XmlElement("journey_index")]
        public long JourneyIndex { get; set; }

        /// <summary>
        /// 乘机人姓名
        /// </summary>
        [XmlElement("passenger_name")]
        public string PassengerName { get; set; }

        /// <summary>
        /// 乘客类型 ADULT CHILD INFANT
        /// </summary>
        [XmlElement("passenger_type")]
        public string PassengerType { get; set; }

        /// <summary>
        /// 预订号
        /// </summary>
        [XmlElement("pnr")]
        public string Pnr { get; set; }

        /// <summary>
        /// 当前航段在所属行程中的顺序，从0开始
        /// </summary>
        [XmlElement("segment_index")]
        public long SegmentIndex { get; set; }

        /// <summary>
        /// OUTBOUND(去程), INBOUND(回程), MULTIBOUND(多程);
        /// </summary>
        [XmlElement("segment_type")]
        public string SegmentType { get; set; }

        /// <summary>
        /// 乘客票号
        /// </summary>
        [XmlElement("ticket_no")]
        public string TicketNo { get; set; }
    }
}
