using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVResponsePaymentInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVResponsePaymentInfoDTO : AopObject
    {
        /// <summary>
        /// 账户名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public TuitionMoneyDTO Amount { get; set; }

        /// <summary>
        /// bank_code
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 截止日期
        /// </summary>
        [XmlElement("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 付款人身份证
        /// </summary>
        [XmlElement("payer_identity_card_number")]
        public string PayerIdentityCardNumber { get; set; }

        /// <summary>
        /// 付款手机号
        /// </summary>
        [XmlElement("payer_phone_number")]
        public string PayerPhoneNumber { get; set; }

        /// <summary>
        /// 附言
        /// </summary>
        [XmlElement("post_script")]
        public string PostScript { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// swift code
        /// </summary>
        [XmlElement("swift_code")]
        public string SwiftCode { get; set; }
    }
}
