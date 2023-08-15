using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FaasDatabaseHistorie Data Structure.
    /// </summary>
    [Serializable]
    public class FaasDatabaseHistorie : AopObject
    {
        /// <summary>
        /// 任务执行进度
        /// </summary>
        [XmlElement("process")]
        public string Process { get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务执行状态  - SUBMIT  - SUCCESS  - FAILED  - CANCEL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 执行命令的序号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务类型  - IMPORT  - EXPORT
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
