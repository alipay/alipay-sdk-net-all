using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBsEnrollSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBsEnrollSubmitModel : AopObject
    {
        /// <summary>
        /// 报名参与者，支持批量传参，最大10
        /// </summary>
        [XmlArray("participants")]
        [XmlArrayItem("bs_enroll_participant")]
        public List<BsEnrollParticipant> Participants { get; set; }

        /// <summary>
        /// 联营计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
