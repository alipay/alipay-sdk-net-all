using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBsEnrollsRecoverModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBsEnrollsRecoverModel : AopObject
    {
        /// <summary>
        /// 恢复报名参与者，支持批量传参，最大10
        /// </summary>
        [XmlArray("participants")]
        [XmlArrayItem("bs_participant_d_t_o")]
        public List<BsParticipantDTO> Participants { get; set; }

        /// <summary>
        /// 联营计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
