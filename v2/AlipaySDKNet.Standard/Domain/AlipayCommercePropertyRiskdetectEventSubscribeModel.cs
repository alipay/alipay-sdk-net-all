using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyRiskdetectEventSubscribeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyRiskdetectEventSubscribeModel : AopObject
    {
        /// <summary>
        /// 生效状态： ON   上线 OFF  下线
        /// </summary>
        [XmlElement("active_status")]
        public string ActiveStatus { get; set; }

        /// <summary>
        /// 外部设备id。说明：同一个对接方下不可重复
        /// </summary>
        [XmlElement("out_device_id")]
        public string OutDeviceId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("register_events")]
        [XmlArrayItem("detect_event")]
        public List<DetectEvent> RegisterEvents { get; set; }
    }
}
