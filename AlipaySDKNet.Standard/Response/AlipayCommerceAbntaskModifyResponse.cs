using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAbntaskModifyResponse.
    /// </summary>
    public class AlipayCommerceAbntaskModifyResponse : AopResponse
    {
        /// <summary>
        /// 操作失败任务数量
        /// </summary>
        [XmlElement("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 失败任务明细列表
        /// </summary>
        [XmlArray("fail_task_details")]
        [XmlArrayItem("fail_task_detail")]
        public List<FailTaskDetail> FailTaskDetails { get; set; }

        /// <summary>
        /// 操作成功任务数量
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
