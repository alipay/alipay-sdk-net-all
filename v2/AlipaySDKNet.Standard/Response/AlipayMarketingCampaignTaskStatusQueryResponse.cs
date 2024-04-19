using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignTaskStatusQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignTaskStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务奖品流水集合
        /// </summary>
        [XmlArray("task_prize_send_info_list")]
        [XmlArrayItem("task_prize_send_info")]
        public List<TaskPrizeSendInfo> TaskPrizeSendInfoList { get; set; }

        /// <summary>
        /// 任务状态信息集合
        /// </summary>
        [XmlArray("task_status_list")]
        [XmlArrayItem("task_status_info")]
        public List<TaskStatusInfo> TaskStatusList { get; set; }
    }
}
