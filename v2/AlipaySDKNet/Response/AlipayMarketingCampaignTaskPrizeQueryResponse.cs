using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignTaskPrizeQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignTaskPrizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 发奖流水任务-详情关系列表
        /// </summary>
        [XmlArray("task_prize_send_info_list")]
        [XmlArrayItem("task_prize_send_info")]
        public List<TaskPrizeSendInfo> TaskPrizeSendInfoList { get; set; }
    }
}
