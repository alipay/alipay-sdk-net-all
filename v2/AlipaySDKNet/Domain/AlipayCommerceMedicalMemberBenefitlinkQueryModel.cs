using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMemberBenefitlinkQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMemberBenefitlinkQueryModel : AopObject
    {
        /// <summary>
        /// 权益编码
        /// </summary>
        [XmlElement("benefit_code")]
        public string BenefitCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
