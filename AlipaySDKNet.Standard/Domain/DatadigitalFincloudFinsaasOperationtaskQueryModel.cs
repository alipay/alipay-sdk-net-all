using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasOperationtaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasOperationtaskQueryModel : AopObject
    {
        /// <summary>
        /// operation_task_id + 唯一 + 运营任务查询 + 批量查询接口会返回该值。
        /// </summary>
        [XmlElement("operation_task_id")]
        public string OperationTaskId { get; set; }

        /// <summary>
        /// tenant_code + 唯一 + 接口必传 + 从 IAM 获取
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
