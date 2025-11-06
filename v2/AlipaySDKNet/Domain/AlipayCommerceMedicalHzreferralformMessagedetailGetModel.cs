using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHzreferralformMessagedetailGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHzreferralformMessagedetailGetModel : AopObject
    {
        /// <summary>
        /// 跳转智能体时的自动query
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 加密后的转诊单ID
        /// </summary>
        [XmlElement("referral_from_id")]
        public string ReferralFromId { get; set; }
    }
}
