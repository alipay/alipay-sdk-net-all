using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentAgreementInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentAgreementInfo : AopObject
    {
        /// <summary>
        /// 租赁协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 资金委托授权协议，默认为空，特殊场景提供。
        /// </summary>
        [XmlElement("deduct_agreement_no")]
        public string DeductAgreementNo { get; set; }

        /// <summary>
        /// 用户脱敏登陆号
        /// </summary>
        [XmlElement("rent_logon_id")]
        public string RentLogonId { get; set; }

        /// <summary>
        /// 租赁用户uid
        /// </summary>
        [XmlElement("rent_user_id")]
        public string RentUserId { get; set; }

        /// <summary>
        /// 租赁用户openId
        /// </summary>
        [XmlElement("rent_user_open_id")]
        public string RentUserOpenId { get; set; }
    }
}
