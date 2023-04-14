using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTaskDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTaskDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务详情信息
        /// </summary>
        [XmlElement("task_detail_info")]
        public TaskDetailInfo TaskDetailInfo { get; set; }

        /// <summary>
        /// 任务详情信息
        /// </summary>
        [XmlArray("task_voucher_list")]
        [XmlArrayItem("task_voucher_info")]
        public List<TaskVoucherInfo> TaskVoucherList { get; set; }
    }
}
