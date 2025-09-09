using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerSegmentOfPassengersChangedInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerSegmentOfPassengersChangedInfo : AopObject
    {
        /// <summary>
        /// 到达机场是否变更
        /// </summary>
        [XmlElement("arrive_airport_changed")]
        public bool ArriveAirportChanged { get; set; }

        /// <summary>
        /// 到达时间是否变更
        /// </summary>
        [XmlElement("arrive_time_changed")]
        public bool ArriveTimeChanged { get; set; }

        /// <summary>
        /// 出发机场是否变更
        /// </summary>
        [XmlElement("depart_airport_changed")]
        public bool DepartAirportChanged { get; set; }

        /// <summary>
        /// 出发时间是否变更
        /// </summary>
        [XmlElement("depart_time_changed")]
        public bool DepartTimeChanged { get; set; }

        /// <summary>
        /// 航班号是否变更
        /// </summary>
        [XmlElement("flight_no_changed")]
        public bool FlightNoChanged { get; set; }

        /// <summary>
        /// 需要乘客确认座位
        /// </summary>
        [XmlElement("need_confirm_seat")]
        public bool NeedConfirmSeat { get; set; }

        /// <summary>
        /// 三字码，例如：PEK
        /// </summary>
        [XmlElement("new_arrive_airport_code")]
        public string NewArriveAirportCode { get; set; }

        /// <summary>
        /// 三字码，例如：PEK
        /// </summary>
        [XmlElement("new_depart_airport_code")]
        public string NewDepartAirportCode { get; set; }

        /// <summary>
        /// 新出发时间 格式(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [XmlElement("new_depart_time")]
        public string NewDepartTime { get; set; }

        /// <summary>
        /// 新航班号
        /// </summary>
        [XmlElement("new_flight_no")]
        public string NewFlightNo { get; set; }

        /// <summary>
        /// 三字码，例如：PEK
        /// </summary>
        [XmlElement("old_arrive_airport_code")]
        public string OldArriveAirportCode { get; set; }

        /// <summary>
        /// 三字码，例如：PEK
        /// </summary>
        [XmlElement("old_depart_airport_code")]
        public string OldDepartAirportCode { get; set; }

        /// <summary>
        /// 原出发时间 格式(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [XmlElement("old_depart_time")]
        public string OldDepartTime { get; set; }

        /// <summary>
        /// 原航班号
        /// </summary>
        [XmlElement("old_flight_no")]
        public string OldFlightNo { get; set; }

        /// <summary>
        /// 乘机人姓名
        /// </summary>
        [XmlElement("passenger_name")]
        public string PassengerName { get; set; }
    }
}
