using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotMarketingPlanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMarketingPlanQueryModel : AopObject
    {
        /// <summary>
        /// 投放计划id,取创建接口返回的plan_id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
