using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasOperationtaskModifyResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasOperationtaskModifyResponse : AopResponse
    {
        /// <summary>
        /// operation_task_id + 运营任务修改 + 数据库
        /// </summary>
        [XmlElement("operation_task_id")]
        public string OperationTaskId { get; set; }
    }
}
