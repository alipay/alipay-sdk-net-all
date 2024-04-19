using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLeaseEnrollGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLeaseEnrollGetModel : AopObject
    {
        /// <summary>
        /// 租赁计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
