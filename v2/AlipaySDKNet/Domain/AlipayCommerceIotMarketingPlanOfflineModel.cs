using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotMarketingPlanOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMarketingPlanOfflineModel : AopObject
    {
        /// <summary>
        /// 投放计划id，取海报投放创建接口返回的plan_id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
