using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationBsEnrollsStopResponse.
    /// </summary>
    public class AlipayCommerceOperationBsEnrollsStopResponse : AopResponse
    {
        /// <summary>
        /// 中止失败的参与者列表
        /// </summary>
        [XmlArray("failed_participants")]
        [XmlArrayItem("bs_participant_response_d_t_o")]
        public List<BsParticipantResponseDTO> FailedParticipants { get; set; }
    }
}
