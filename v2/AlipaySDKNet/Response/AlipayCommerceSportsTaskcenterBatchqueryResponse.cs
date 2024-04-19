using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSportsTaskcenterBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceSportsTaskcenterBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用户任务简单对象列表
        /// </summary>
        [XmlArray("user_task_list")]
        [XmlArrayItem("user_task_simple_dto")]
        public List<UserTaskSimpleDto> UserTaskList { get; set; }
    }
}
