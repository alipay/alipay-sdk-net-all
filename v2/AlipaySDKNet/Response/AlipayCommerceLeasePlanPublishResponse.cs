using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLeasePlanPublishResponse.
    /// </summary>
    public class AlipayCommerceLeasePlanPublishResponse : AopResponse
    {
        /// <summary>
        /// 租赁计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
