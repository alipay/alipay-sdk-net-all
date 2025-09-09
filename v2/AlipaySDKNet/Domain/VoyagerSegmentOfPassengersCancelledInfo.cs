using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerSegmentOfPassengersCancelledInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerSegmentOfPassengersCancelledInfo : AopObject
    {
        /// <summary>
        /// 到达城市
        /// </summary>
        [XmlElement("arrive_city_code")]
        public string ArriveCityCode { get; set; }

        /// <summary>
        /// 出发城市
        /// </summary>
        [XmlElement("depart_city_code")]
        public string DepartCityCode { get; set; }

        /// <summary>
        /// 出发时间 格式(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [XmlElement("depart_time")]
        public string DepartTime { get; set; }

        /// <summary>
        /// 航班号
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }

        /// <summary>
        /// 乘机人姓名
        /// </summary>
        [XmlElement("passenger_name")]
        public string PassengerName { get; set; }
    }
}
