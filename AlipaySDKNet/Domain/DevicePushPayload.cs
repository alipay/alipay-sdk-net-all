using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DevicePushPayload Data Structure.
    /// </summary>
    [Serializable]
    public class DevicePushPayload : AopObject
    {
        /// <summary>
        /// 设备唯一ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 消息通知数据模型
        /// </summary>
        [XmlElement("notify_params")]
        public string NotifyParams { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
