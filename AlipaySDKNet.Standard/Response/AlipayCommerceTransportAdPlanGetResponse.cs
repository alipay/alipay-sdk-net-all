using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanGetResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanGetResponse : AopResponse
    {
        /// <summary>
        /// 计划详情
        /// </summary>
        [XmlElement("plan_result")]
        public AdPlan PlanResult { get; set; }
    }
}
