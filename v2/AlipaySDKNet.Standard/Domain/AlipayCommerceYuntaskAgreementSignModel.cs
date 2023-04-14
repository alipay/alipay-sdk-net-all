using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskAgreementSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskAgreementSignModel : AopObject
    {
        /// <summary>
        /// 商户签约号，代扣协议中标示用户的唯一签约号，同一 external_agreement_no只会发起一次授权。 格式规则：支持大写小写字母和数字，最长32位。
        /// </summary>
        [XmlElement("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 资金代扣签约时的出资方uid
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }
    }
}
