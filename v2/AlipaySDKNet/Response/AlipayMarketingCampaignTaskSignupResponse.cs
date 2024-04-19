using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignTaskSignupResponse.
    /// </summary>
    public class AlipayMarketingCampaignTaskSignupResponse : AopResponse
    {
        /// <summary>
        /// 任务基本信息
        /// </summary>
        [XmlElement("task_base_info")]
        public TaskBaseInfo TaskBaseInfo { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 是否报名成功
        /// </summary>
        [XmlElement("trigger_result")]
        public bool TriggerResult { get; set; }
    }
}
