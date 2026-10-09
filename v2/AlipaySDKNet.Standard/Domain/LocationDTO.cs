using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LocationDTO : AopObject
    {
        /// <summary>
        /// 所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 使用设备的IMEI号
        /// </summary>
        [XmlElement("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 使用设备的IMSI号
        /// </summary>
        [XmlElement("imsi")]
        public string Imsi { get; set; }

        /// <summary>
        /// 使用设备的IP地址
        /// </summary>
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 使用设备的Wi-Fi物理地址
        /// </summary>
        [XmlElement("mac_addr")]
        public string MacAddr { get; set; }
    }
}
