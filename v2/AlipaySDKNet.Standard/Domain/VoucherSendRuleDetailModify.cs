using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSendRuleDetailModify Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSendRuleDetailModify : AopObject
    {
        /// <summary>
        /// 是否开启自然人领取限制。 自然人表示按照身份证纬度进行领取限制。
        /// </summary>
        [XmlElement("natural_person_limit")]
        public bool NaturalPersonLimit { get; set; }

        /// <summary>
        /// 是否开启电话号码领取限制。
        /// </summary>
        [XmlElement("phone_number_limit")]
        public string PhoneNumberLimit { get; set; }

        /// <summary>
        /// 每人领取限制。 默认按照支付宝uid进行领取限制;
        /// </summary>
        [XmlElement("voucher_quantity_limit_per_user")]
        public long VoucherQuantityLimitPerUser { get; set; }
    }
}
