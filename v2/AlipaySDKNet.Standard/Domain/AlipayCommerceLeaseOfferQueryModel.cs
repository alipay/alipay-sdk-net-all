using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLeaseOfferQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLeaseOfferQueryModel : AopObject
    {
        /// <summary>
        /// 租赁商pid
        /// </summary>
        [XmlElement("lessor_pid")]
        public string LessorPid { get; set; }

        /// <summary>
        /// 租赁计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
