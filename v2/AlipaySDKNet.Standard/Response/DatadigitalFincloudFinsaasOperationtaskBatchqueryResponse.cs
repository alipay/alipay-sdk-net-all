using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasOperationtaskBatchqueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasOperationtaskBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// operation_task + 运营任务模糊查询 + 数据库。
        /// </summary>
        [XmlArray("operation_tasks")]
        [XmlArrayItem("operation_task_d_t_o")]
        public List<OperationTaskDTO> OperationTasks { get; set; }

        /// <summary>
        /// total + 运营任务模糊查询 + 数据库
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
