using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationBsEnrollSubmitResponse.
    /// </summary>
    public class AlipayCommerceOperationBsEnrollSubmitResponse : AopResponse
    {
        /// <summary>
        /// 处理失败的参与者列表
        /// </summary>
        [XmlArray("failed_participants")]
        [XmlArrayItem("bs_enroll_participant")]
        public List<BsEnrollParticipant> FailedParticipants { get; set; }

        /// <summary>
        /// 报名结果，包括报名成功和报名失败。 入参使用participants_new时，返回该字段
        /// </summary>
        [XmlArray("participants_result")]
        [XmlArrayItem("bs_enroll_participant_result")]
        public List<BsEnrollParticipantResult> ParticipantsResult { get; set; }
    }
}
