using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsVoiceEventTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsVoiceEventTriggerModel : AopObject
    {
        /// <summary>
        /// 提示音类型
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// N6D设备序列号
        /// </summary>
        [XmlElement("sn_id")]
        public string SnId { get; set; }
    }
}
