using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StatesSyncPayload Data Structure.
    /// </summary>
    [Serializable]
    public class StatesSyncPayload : AopObject
    {
        /// <summary>
        /// 智能设备唯一ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        [XmlElement("online")]
        public bool Online { get; set; }

        /// <summary>
        /// 状态信息Json串
        /// </summary>
        [XmlElement("states")]
        public string States { get; set; }
    }
}
