using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWaterUsertaskQueryResponse.
    /// </summary>
    public class AlipayCommerceWaterUsertaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户任务详情
        /// </summary>
        [XmlElement("user_task_list_info")]
        public QueryUserTaskListResponse UserTaskListInfo { get; set; }
    }
}
