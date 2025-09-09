using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficAirticketOrderShareInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficAirticketOrderShareInfo : AopObject
    {
        /// <summary>
        /// 主飞（实际承运）航司二字码
        /// </summary>
        [XmlElement("ac_code")]
        public string AcCode { get; set; }

        /// <summary>
        /// 主飞（实际承运）航司名称
        /// </summary>
        [XmlElement("ac_name")]
        public string AcName { get; set; }

        /// <summary>
        /// 主飞（实际承运）航班号
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }
    }
}
