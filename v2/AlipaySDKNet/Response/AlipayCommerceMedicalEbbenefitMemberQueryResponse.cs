using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalEbbenefitMemberQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalEbbenefitMemberQueryResponse : AopResponse
    {
        /// <summary>
        /// 家庭成员列表
        /// </summary>
        [XmlArray("member")]
        [XmlArrayItem("member_v_o")]
        public List<MemberVO> Member { get; set; }
    }
}
