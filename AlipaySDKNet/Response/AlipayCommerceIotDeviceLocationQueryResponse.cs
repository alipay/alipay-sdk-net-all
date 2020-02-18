using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceLocationQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceLocationQueryResponse : AopResponse
    {
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
        /// 设备位置的获取时间,13位时间戳,精确到毫秒
        /// </summary>
        [XmlElement("time")]
        public long Time { get; set; }
    }
}
