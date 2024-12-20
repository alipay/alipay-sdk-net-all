using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentAgreementInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentAgreementInfoDTO : AopObject
    {
        /// <summary>
        /// 租赁协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 资金委托授权协议，特殊场景涉及，默认为空。
        /// </summary>
        [XmlElement("deduct_agreement_no")]
        public string DeductAgreementNo { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [XmlElement("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 租赁用户id
        /// </summary>
        [XmlElement("rent_user_id")]
        public string RentUserId { get; set; }

        /// <summary>
        /// 租赁用户id
        /// </summary>
        [XmlElement("rent_user_open_id")]
        public string RentUserOpenId { get; set; }

        /// <summary>
        /// 协议状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
