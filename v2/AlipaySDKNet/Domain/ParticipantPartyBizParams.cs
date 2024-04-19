using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantPartyBizParams Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantPartyBizParams : AopObject
    {
        /// <summary>
        /// 当identity_type为ACCOUNT_BOOK_ID时，扩展参数里代扣协议号必填
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 当identity_type为ACCONT_BOOK_ID时此字段为记账本归属UID,且必选
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
