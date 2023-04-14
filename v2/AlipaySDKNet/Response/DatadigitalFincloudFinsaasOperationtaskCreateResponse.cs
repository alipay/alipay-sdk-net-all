using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasOperationtaskCreateResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasOperationtaskCreateResponse : AopResponse
    {
        /// <summary>
        /// operation_task_id + 运营任务创建 + 数据库
        /// </summary>
        [XmlElement("operation_task_id")]
        public string OperationTaskId { get; set; }
    }
}
