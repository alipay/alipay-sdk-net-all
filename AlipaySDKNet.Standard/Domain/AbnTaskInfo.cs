using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AbnTaskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AbnTaskInfo : AopObject
    {
        /// <summary>
        /// 任务扩展信息，json格式字符串，不同的task_type对应不同的扩展信息。
        /// </summary>
        [XmlElement("extens_info")]
        public string ExtensInfo { get; set; }

        /// <summary>
        /// 创建时间，yyyy-MM-dd HH:mm:ss格式字符串
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间，yyyy-MM-dd HH:mm:ss格式字符串
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 处理人id，多个时使用英文逗号","分隔
        /// </summary>
        [XmlElement("handler_id")]
        public string HandlerId { get; set; }

        /// <summary>
        /// 处理人昵称，多个时使用英文逗号","分隔
        /// </summary>
        [XmlElement("handler_nick")]
        public string HandlerNick { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务级别： 紧急、高、中、低
        /// </summary>
        [XmlElement("task_level")]
        public string TaskLevel { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务操作记录集合
        /// </summary>
        [XmlArray("task_operation_logs")]
        [XmlArrayItem("task_operation_log")]
        public List<TaskOperationLog> TaskOperationLogs { get; set; }

        /// <summary>
        /// 任务状态: CREATED：待响应， RESPONSED：处理中 DEALED：已完成
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务类型 MERCHANT_TRADE_DROPZERO：商户交易跌零任务
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
