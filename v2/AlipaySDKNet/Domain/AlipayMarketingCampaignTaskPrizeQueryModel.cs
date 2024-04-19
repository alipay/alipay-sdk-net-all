using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignTaskPrizeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignTaskPrizeQueryModel : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务中心id
        /// </summary>
        [XmlElement("task_cen_id")]
        public string TaskCenId { get; set; }

        /// <summary>
        /// 出资的支付宝用户id 限制: 1、登录账号和用户ID必须且只能二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
