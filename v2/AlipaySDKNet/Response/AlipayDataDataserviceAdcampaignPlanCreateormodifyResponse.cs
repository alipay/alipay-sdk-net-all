using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignPlanCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignPlanCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 计划ID，唯一键
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }
    }
}
