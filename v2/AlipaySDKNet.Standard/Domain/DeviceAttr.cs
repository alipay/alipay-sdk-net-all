using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceAttr Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceAttr : AopObject
    {
        /// <summary>
        /// 设备其他属性key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 设备其他属性value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
