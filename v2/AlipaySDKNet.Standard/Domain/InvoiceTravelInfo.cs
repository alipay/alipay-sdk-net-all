using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTravelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTravelInfo : AopObject
    {
        /// <summary>
        /// 脱敏的有效证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，如 RESIDENT_IDENTITY_CARD
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 到达地/下车站名称
        /// </summary>
        [XmlElement("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 出发地/上车站名称
        /// </summary>
        [XmlElement("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// 出行日期，格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("travel_date")]
        public string TravelDate { get; set; }

        /// <summary>
        /// 出行人姓名
        /// </summary>
        [XmlElement("traveller_name")]
        public string TravellerName { get; set; }

        /// <summary>
        /// 交通工具等级，需与交通工具类型符合通用旅客运输规则
        /// </summary>
        [XmlElement("vehicle_level")]
        public string VehicleLevel { get; set; }

        /// <summary>
        /// 交通工具类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }
    }
}
