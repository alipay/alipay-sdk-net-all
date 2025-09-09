using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalEbbenefitMemberGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalEbbenefitMemberGetModel : AopObject
    {
        /// <summary>
        /// 会员id
        /// </summary>
        [XmlElement("eb_user_id")]
        public string EbUserId { get; set; }

        /// <summary>
        /// 支付宝家庭成员id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 外部自有用户id，无特殊校验
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }
    }
}
