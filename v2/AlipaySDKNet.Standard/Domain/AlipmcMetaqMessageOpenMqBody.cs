using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipmcMetaqMessageOpenMqBody Data Structure.
    /// </summary>
    [Serializable]
    public class AlipmcMetaqMessageOpenMqBody : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动实例id
        /// </summary>
        [XmlElement("activity_instance_id")]
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("alipmc_message_id")]
        public string AlipmcMessageId { get; set; }

        /// <summary>
        /// 是否历史
        /// </summary>
        [XmlElement("before")]
        public bool Before { get; set; }

        /// <summary>
        /// 类型别名
        /// </summary>
        [XmlElement("class_alias")]
        public string ClassAlias { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        [XmlElement("exception_info")]
        public string ExceptionInfo { get; set; }

        /// <summary>
        /// 通知消息类型
        /// </summary>
        [XmlElement("notify_message_type")]
        public string NotifyMessageType { get; set; }

        /// <summary>
        /// 消息topic
        /// </summary>
        [XmlElement("notify_topic")]
        public string NotifyTopic { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("out_result")]
        public string OutResult { get; set; }

        /// <summary>
        /// 流程code
        /// </summary>
        [XmlElement("process_code")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 流程id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 流程实例id
        /// </summary>
        [XmlElement("process_instance_id")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 恢复流程id
        /// </summary>
        [XmlElement("resumption_id")]
        public string ResumptionId { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
