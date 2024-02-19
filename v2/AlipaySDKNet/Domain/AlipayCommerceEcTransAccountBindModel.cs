using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTransAccountBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTransAccountBindModel : AopObject
    {
        /// <summary>
        /// 资金专户ID
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 被授权方的支付宝登录账号
        /// </summary>
        [XmlElement("participant_login_id")]
        public string ParticipantLoginId { get; set; }
    }
}
