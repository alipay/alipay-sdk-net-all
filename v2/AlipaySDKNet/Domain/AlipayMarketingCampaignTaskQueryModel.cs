using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignTaskQueryModel : AopObject
    {
        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 任务中心id
        /// </summary>
        [XmlElement("task_cen_id")]
        public string TaskCenId { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlArray("task_ids")]
        [XmlArrayItem("string")]
        public List<string> TaskIds { get; set; }

        /// <summary>
        /// 出资的支付宝用户id 限制: 1、登录账号和用户ID必须且只能二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
