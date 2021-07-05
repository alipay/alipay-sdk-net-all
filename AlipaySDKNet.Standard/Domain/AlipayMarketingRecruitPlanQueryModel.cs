using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitPlanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingRecruitPlanQueryModel : AopObject
    {
        /// <summary>
        /// 招商方案ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
