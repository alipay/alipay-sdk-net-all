using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskEventInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskEventInfo : AopObject
    {
        /// <summary>
        /// 任务事件id，任务事件类型是TRADE_SOURCE时，为支付宝交易号
        /// </summary>
        [XmlElement("task_event_id")]
        public string TaskEventId { get; set; }

        /// <summary>
        /// 任务事件类型（TRADE_SOURCE-交易事件）
        /// </summary>
        [XmlElement("task_event_type")]
        public string TaskEventType { get; set; }
    }
}
