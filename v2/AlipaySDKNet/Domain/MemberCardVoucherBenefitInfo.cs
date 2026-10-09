using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardVoucherBenefitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardVoucherBenefitInfo : AopObject
    {
        /// <summary>
        /// 券权益奖励次数
        /// </summary>
        [XmlElement("modulus")]
        public long Modulus { get; set; }

        /// <summary>
        /// 券活动ID
        /// </summary>
        [XmlElement("voucher_activity_id")]
        public string VoucherActivityId { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 商家券 MERCHANT_VOUCHER 支付券 PAYMENT_VOUCHER
        /// </summary>
        [XmlElement("vouvher_type")]
        public string VouvherType { get; set; }
    }
}
