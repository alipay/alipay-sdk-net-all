using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasOperationtaskBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasOperationtaskBatchqueryModel : AopObject
    {
        /// <summary>
        /// execution_time + 运营活动查询 + 前端
        /// </summary>
        [XmlElement("execution_time")]
        public string ExecutionTime { get; set; }

        /// <summary>
        /// operation_task_name + 运营任务查询 + 前端。
        /// </summary>
        [XmlElement("operation_task_name")]
        public string OperationTaskName { get; set; }

        /// <summary>
        /// operation_task_type + 运营任务查询
        /// </summary>
        [XmlElement("operation_task_type")]
        public string OperationTaskType { get; set; }

        /// <summary>
        /// page_num + 运营任务查询 + 前端
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// page_size + 运营任务查询 + 前端
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// status + 运营任务查询 + 前端。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// tenant_code + 唯一 + 接口必传 + 从 IAM 获取
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }

        /// <summary>
        /// user_ids + 运营任务模糊查询 + IAM
        /// </summary>
        [XmlElement("user_ids")]
        public string UserIds { get; set; }

        /// <summary>
        /// user_name + 运营任务查询 + IAM。
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
