using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalEbbenefitMemberBindResponse.
    /// </summary>
    public class AlipayCommerceMedicalEbbenefitMemberBindResponse : AopResponse
    {
        /// <summary>
        /// 支付宝家庭成员id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }
    }
}
