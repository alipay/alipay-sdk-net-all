using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentGlassesUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentGlassesUnbindModel : AopObject
    {
        /// <summary>
        /// 设备SN，眼镜厂商唯一设备号
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 解绑用户open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 解绑用户user_id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
