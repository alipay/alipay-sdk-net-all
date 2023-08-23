using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceSubTaskCreateOpenapiResult Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceSubTaskCreateOpenapiResult : AopObject
    {
        /// <summary>
        /// 子任务ID
        /// </summary>
        [XmlElement("sub_task_id")]
        public string SubTaskId { get; set; }

        /// <summary>
        /// 子任务类型
        /// </summary>
        [XmlElement("sub_task_type")]
        public string SubTaskType { get; set; }

        /// <summary>
        /// 子任务序号
        /// </summary>
        [XmlElement("task_index")]
        public string TaskIndex { get; set; }
    }
}
