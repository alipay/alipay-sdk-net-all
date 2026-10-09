using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWaterTaskBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceWaterTaskBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 任务列表
        /// </summary>
        [XmlArray("task_detail_list_response")]
        [XmlArrayItem("task_detail_list_response")]
        public List<TaskDetailListResponse> TaskDetailListResponse { get; set; }
    }
}
