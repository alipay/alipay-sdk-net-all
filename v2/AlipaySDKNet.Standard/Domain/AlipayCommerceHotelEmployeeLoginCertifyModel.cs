using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelEmployeeLoginCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelEmployeeLoginCertifyModel : AopObject
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
        /// 酒店集团code
        /// </summary>
        [XmlElement("hotel_group_code")]
        public string HotelGroupCode { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
