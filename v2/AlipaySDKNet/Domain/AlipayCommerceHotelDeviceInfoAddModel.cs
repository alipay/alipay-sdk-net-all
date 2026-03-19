using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelDeviceInfoAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelDeviceInfoAddModel : AopObject
    {
        /// <summary>
        /// 设备唯一id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备openid
        /// </summary>
        [XmlElement("device_open_id")]
        public string DeviceOpenId { get; set; }

        /// <summary>
        /// 设备平台
        /// </summary>
        [XmlElement("device_platform")]
        public string DevicePlatform { get; set; }

        /// <summary>
        /// 酒店编码
        /// </summary>
        [XmlElement("hotel_code")]
        public string HotelCode { get; set; }

        /// <summary>
        /// 酒店集团编码
        /// </summary>
        [XmlElement("hotel_group_code")]
        public string HotelGroupCode { get; set; }
    }
}
