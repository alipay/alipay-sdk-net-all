using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMemberBenefitlinkQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMemberBenefitlinkQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益跳转链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }
    }
}
