using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardVoucherBenefitEntity Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardVoucherBenefitEntity : AopObject
    {
        /// <summary>
        /// 发放失败的原因列表
        /// </summary>
        [XmlArray("fail_reason_list")]
        [XmlArrayItem("string")]
        public List<string> FailReasonList { get; set; }

        /// <summary>
        /// 发放成功的券ID列表
        /// </summary>
        [XmlArray("success_voucher_list")]
        [XmlArrayItem("string")]
        public List<string> SuccessVoucherList { get; set; }

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
    }
}
