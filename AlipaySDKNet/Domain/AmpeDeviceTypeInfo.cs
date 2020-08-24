using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmpeDeviceTypeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AmpeDeviceTypeInfo : AopObject
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备类描述
        /// </summary>
        [XmlElement("device_type_desc")]
        public string DeviceTypeDesc { get; set; }
    }
}
