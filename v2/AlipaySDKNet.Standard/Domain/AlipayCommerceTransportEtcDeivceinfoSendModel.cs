using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcDeivceinfoSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcDeivceinfoSendModel : AopObject
    {
        /// <summary>
        /// 设备变更信息
        /// </summary>
        [XmlElement("device_info")]
        public EtcDeviceMsgInfo DeviceInfo { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }
    }
}
