using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenInvoiceTravelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenInvoiceTravelInfo : AopObject
    {
        /// <summary>
        /// 有效证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 到达地
        /// </summary>
        [XmlElement("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 出发地
        /// </summary>
        [XmlElement("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// 出行日期
        /// </summary>
        [XmlElement("travel_date")]
        public string TravelDate { get; set; }

        /// <summary>
        /// 出行人
        /// </summary>
        [XmlElement("traveller_name")]
        public string TravellerName { get; set; }

        /// <summary>
        /// 交通工具等级
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
