using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSendRule Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSendRule : AopObject
    {
        /// <summary>
        /// 是否开启自然人限制。自然人表示按照身份证纬度进行领取限制
        /// </summary>
        [XmlElement("natural_person_limit")]
        public bool NaturalPersonLimit { get; set; }

        /// <summary>
        /// 是否开启电话号码限制
        /// </summary>
        [XmlElement("phone_number_limit")]
        public bool PhoneNumberLimit { get; set; }

        /// <summary>
        /// 拟发行券的数量。单位为张。该数值必须是大于0的整数。  MERCHANT_UPLOAD模式下数量必须为0或者选择不填，默认为0
        /// </summary>
        [XmlElement("voucher_quantity")]
        public long VoucherQuantity { get; set; }

        /// <summary>
        /// 每人领取限，默认按照支付宝uid进行领取限制；  不填写默认没有领取限制.
        /// </summary>
        [XmlElement("voucher_single_restriction")]
        public long VoucherSingleRestriction { get; set; }
    }
}
