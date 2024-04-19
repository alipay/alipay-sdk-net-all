using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TransferInfo : AopObject
    {
        /// <summary>
        /// 中转机场三字码
        /// </summary>
        [XmlElement("transfer_airport")]
        public string TransferAirport { get; set; }

        /// <summary>
        /// 中转机场名称
        /// </summary>
        [XmlElement("transfer_airport_name")]
        public string TransferAirportName { get; set; }

        /// <summary>
        /// 中转城市三字码
        /// </summary>
        [XmlElement("transfer_city")]
        public string TransferCity { get; set; }

        /// <summary>
        /// 中转城市名称
        /// </summary>
        [XmlElement("transfer_city_name")]
        public string TransferCityName { get; set; }

        /// <summary>
        /// 中转时长，单位：秒
        /// </summary>
        [XmlElement("transfer_time")]
        public long TransferTime { get; set; }
    }
}
