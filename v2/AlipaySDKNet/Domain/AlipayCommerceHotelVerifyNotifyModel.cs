using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelVerifyNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelVerifyNotifyModel : AopObject
    {
        /// <summary>
        /// 设备唯一id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

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

        /// <summary>
        /// 名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 核身id
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
