using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UpdateContentExtAttribute Data Structure.
    /// </summary>
    [Serializable]
    public class UpdateContentExtAttribute : AopObject
    {
        /// <summary>
        /// 设备外挂配件的SN号，仅设备有外挂配件时需要传
        /// </summary>
        [XmlElement("accessory_sn")]
        public string AccessorySn { get; set; }

        /// <summary>
        /// 服务商密钥
        /// </summary>
        [XmlElement("isv_access_token")]
        public string IsvAccessToken { get; set; }

        /// <summary>
        /// 小写字母串_服务商PID
        /// </summary>
        [XmlElement("isv_device_version_tag")]
        public string IsvDeviceVersionTag { get; set; }
    }
}
