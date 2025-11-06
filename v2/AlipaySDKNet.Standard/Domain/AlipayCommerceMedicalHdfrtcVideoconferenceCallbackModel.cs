using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcVideoconferenceCallbackModel : AopObject
    {
        /// <summary>
        /// 回调消息具体内容
        /// </summary>
        [XmlElement("event_data")]
        public string EventData { get; set; }

        /// <summary>
        /// 事件ID
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 通知时间戳，单位：毫秒
        /// </summary>
        [XmlElement("notify_time")]
        public long NotifyTime { get; set; }
    }
}
