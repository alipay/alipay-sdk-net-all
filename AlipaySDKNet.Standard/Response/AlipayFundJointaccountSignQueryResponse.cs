using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountSignQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业签约的账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 企业授权平台的三方授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 账户状态，NORMAL-生效中，RELEASED-已销户
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
