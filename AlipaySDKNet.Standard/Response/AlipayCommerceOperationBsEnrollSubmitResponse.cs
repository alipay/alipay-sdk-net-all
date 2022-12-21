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
    }
}
