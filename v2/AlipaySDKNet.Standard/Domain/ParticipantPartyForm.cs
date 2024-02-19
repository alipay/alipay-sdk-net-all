using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantPartyForm Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantPartyForm : AopObject
    {
        /// <summary>
        /// 参与者的业务身份标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// ALIPAY_OPEN_ID代表identity为支付宝开放用户ID；ALIPAY_LOGON_ID代表identity为支付宝用户登录号； ACCONT_BOOK_ID代表identity为记账本ID
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 用户姓名，在identity_type为ALIPAY_LOGON_ID时必填
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 当identity_type为ACCOUNT_BOOK_ID时，partner_id为归属UID，必选
        /// </summary>
        [XmlElement("participant_party_biz_params")]
        public ParticipantPartyBizParams ParticipantPartyBizParams { get; set; }
    }
}
