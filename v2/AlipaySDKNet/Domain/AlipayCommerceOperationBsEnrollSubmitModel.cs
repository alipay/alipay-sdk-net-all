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
        /// 外部商户活动id，请确保在自己域内唯一。 plan_id为空时，该参数必传
        /// </summary>
        [XmlElement("out_activity_id")]
        public string OutActivityId { get; set; }

        /// <summary>
        /// 报名参与者，支持批量传参，最大10 当前字段已废弃(新接入场景请使用participants_new)
        /// </summary>
        [XmlArray("participants")]
        [XmlArrayItem("bs_enroll_participant")]
        public List<BsEnrollParticipant> Participants { get; set; }

        /// <summary>
        /// 报名对象，新接入场景都是用该属性
        /// </summary>
        [XmlArray("participants_new")]
        [XmlArrayItem("bs_enroll_new_participant")]
        public List<BsEnrollNewParticipant> ParticipantsNew { get; set; }

        /// <summary>
        /// 联营计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 没传plan_id的场景，需要传该参数
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
