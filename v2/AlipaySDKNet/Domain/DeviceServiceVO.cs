using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceServiceVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceServiceVO : AopObject
    {
        /// <summary>
        /// 拥有服务的设备基础信息
        /// </summary>
        [XmlElement("device_service_base")]
        public DeviceServiceBaseVO DeviceServiceBase { get; set; }

        /// <summary>
        /// 如果拥有服务的设备为间联子设备，则这里会带上网关设备信息
        /// </summary>
        [XmlElement("parent_base")]
        public DeviceServiceBaseVO ParentBase { get; set; }

        /// <summary>
        /// 服务模型key
        /// </summary>
        [XmlElement("service_key")]
        public string ServiceKey { get; set; }

        /// <summary>
        /// 服务模型内部版本号
        /// </summary>
        [XmlElement("version_no")]
        public long VersionNo { get; set; }
    }
}
