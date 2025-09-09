using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperationList Data Structure.
    /// </summary>
    [Serializable]
    public class OperationList : AopObject
    {
        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务执行进度
        /// </summary>
        [XmlElement("task_progress")]
        public string TaskProgress { get; set; }

        /// <summary>
        /// 任务起始时间
        /// </summary>
        [XmlElement("task_start_time")]
        public string TaskStartTime { get; set; }

        /// <summary>
        /// 任务执行状态:0:为成功，1:为执行中，2:为失败
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
