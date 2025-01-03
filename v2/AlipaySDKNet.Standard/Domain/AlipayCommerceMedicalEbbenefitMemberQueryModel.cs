using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalEbbenefitMemberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalEbbenefitMemberQueryModel : AopObject
    {
        /// <summary>
        /// 外部自有会员Id，无特殊校验
        /// </summary>
        [XmlElement("eb_user_id")]
        public string EbUserId { get; set; }

        /// <summary>
        /// 外部自有用户id，无特殊校验
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }
    }
}
