using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalEbbenefitMemberAddResponse.
    /// </summary>
    public class AlipayCommerceMedicalEbbenefitMemberAddResponse : AopResponse
    {
        /// <summary>
        /// 家庭成员id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }
    }
}
