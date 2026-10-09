using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignTaskSendResponse.
    /// </summary>
    public class AlipayMarketingCampaignTaskSendResponse : AopResponse
    {
        /// <summary>
        /// 任务基本属性信息
        /// </summary>
        [XmlElement("task_base_info")]
        public TaskBaseInfo TaskBaseInfo { get; set; }

        /// <summary>
        /// 任务唯一id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务完成标志
        /// </summary>
        [XmlElement("trigger_result")]
        public bool TriggerResult { get; set; }
    }
}
