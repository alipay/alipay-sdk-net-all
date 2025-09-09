using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCouponCodeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCouponCodeDTO : AopObject
    {
        /// <summary>
        /// 会员卡卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 券码号码
        /// </summary>
        [XmlElement("member_code")]
        public string MemberCode { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 会员卡有效期
        /// </summary>
        [XmlElement("validity_period")]
        public string ValidityPeriod { get; set; }
    }
}
