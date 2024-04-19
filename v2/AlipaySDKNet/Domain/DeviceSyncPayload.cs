using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceSyncPayload Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceSyncPayload : AopObject
    {
        /// <summary>
        /// 触发行为:绑定、解绑、变更等
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 智能设备唯一ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }
    }
}
