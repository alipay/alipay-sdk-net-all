using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAgreementDelegationSignResponse.
    /// </summary>
    public class AlipayUserAgreementDelegationSignResponse : AopResponse
    {
        /// <summary>
        /// AI支付协议号
        /// </summary>
        [XmlElement("ai_pay_agreement_no")]
        public string AiPayAgreementNo { get; set; }

        /// <summary>
        /// 委托号，用于发起支付
        /// </summary>
        [XmlElement("delegation_id")]
        public string DelegationId { get; set; }

        /// <summary>
        /// 外部委托号
        /// </summary>
        [XmlElement("external_delegation_id")]
        public string ExternalDelegationId { get; set; }

        /// <summary>
        /// 免密协议号
        /// </summary>
        [XmlElement("no_pwd_agreement_no")]
        public string NoPwdAgreementNo { get; set; }
    }
}
