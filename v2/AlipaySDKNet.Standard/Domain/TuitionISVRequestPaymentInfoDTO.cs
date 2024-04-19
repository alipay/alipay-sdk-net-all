using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVRequestPaymentInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVRequestPaymentInfoDTO : AopObject
    {
        /// <summary>
        /// 170
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 留学金额
        /// </summary>
        [XmlElement("amount")]
        public TuitionMoneyDTO Amount { get; set; }

        /// <summary>
        /// 证书列表
        /// </summary>
        [XmlElement("certificate_list")]
        public string CertificateList { get; set; }

        /// <summary>
        /// 缴费截止日期
        /// </summary>
        [XmlElement("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 付款人身份证号
        /// </summary>
        [XmlElement("payer_identity_card_number")]
        public string PayerIdentityCardNumber { get; set; }

        /// <summary>
        /// 缴费手机号
        /// </summary>
        [XmlElement("payer_phone_number")]
        public string PayerPhoneNumber { get; set; }

        /// <summary>
        /// 附言
        /// </summary>
        [XmlElement("post_script")]
        public string PostScript { get; set; }

        /// <summary>
        /// 学校id
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }
    }
}
