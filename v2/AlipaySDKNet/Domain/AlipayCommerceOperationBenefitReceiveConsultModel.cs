using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBenefitReceiveConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBenefitReceiveConsultModel : AopObject
    {
        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
