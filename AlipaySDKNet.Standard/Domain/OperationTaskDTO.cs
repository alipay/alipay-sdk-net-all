using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperationTaskDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OperationTaskDTO : AopObject
    {
        /// <summary>
        /// comment + 运营任务模糊查询 + 数据库
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// operation_task_id + 唯一 + 运营任务查询 + 数据库。
        /// </summary>
        [XmlElement("operation_task_id")]
        public string OperationTaskId { get; set; }

        /// <summary>
        /// operation_task_name + 运营任务查询 + 数据库。
        /// </summary>
        [XmlElement("operation_task_name")]
        public string OperationTaskName { get; set; }

        /// <summary>
        /// operation_task_type + 运营任务查询 + 数据库。
        /// </summary>
        [XmlElement("operation_task_type")]
        public string OperationTaskType { get; set; }

        /// <summary>
        /// plan_end_time + 运营任务查询 + 数据库。
        /// </summary>
        [XmlElement("plan_end_time")]
        public string PlanEndTime { get; set; }

        /// <summary>
        /// plan_start_time + 运营任务查询 + 数据库。
        /// </summary>
        [XmlElement("plan_start_time")]
        public string PlanStartTime { get; set; }

        /// <summary>
        /// reject_comment + 运营任务模糊查询 + 数据库
        /// </summary>
        [XmlElement("reject_comment")]
        public string RejectComment { get; set; }

        /// <summary>
        /// status + 运营任务查询 + 数据库。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// statusName + 运营任务查询 + 数据库。
        /// </summary>
        [XmlElement("status_name")]
        public string StatusName { get; set; }

        /// <summary>
        /// user_id + 运营任务查询 + 数据库。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// user_name + 运营任务查询 + 数据库。
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
