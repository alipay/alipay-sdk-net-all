using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasOperationtaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasOperationtaskCreateModel : AopObject
    {
        /// <summary>
        /// comment + 运营任务创建 + 前端
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// config + 运营任务创建 + 前端
        /// </summary>
        [XmlElement("config")]
        public string Config { get; set; }

        /// <summary>
        /// operation_task_name + 运营任务创建 + 前端输入。
        /// </summary>
        [XmlElement("operation_task_name")]
        public string OperationTaskName { get; set; }

        /// <summary>
        /// operation_task_type + 运营任务创建 + 前端
        /// </summary>
        [XmlElement("operation_task_type")]
        public string OperationTaskType { get; set; }

        /// <summary>
        /// plan_end_time + 运营任务创建 + 前端
        /// </summary>
        [XmlElement("plan_end_time")]
        public string PlanEndTime { get; set; }

        /// <summary>
        /// plan_start_time + 运营任务创建 + 前端
        /// </summary>
        [XmlElement("plan_start_time")]
        public string PlanStartTime { get; set; }

        /// <summary>
        /// status + 运营任务创建 + 前端
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// tenant_code + 运营任务创建 + IAM
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }

        /// <summary>
        /// user_id + 运营任务创建 + IAM
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// user_name + 运营任务创建 + IAM
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
