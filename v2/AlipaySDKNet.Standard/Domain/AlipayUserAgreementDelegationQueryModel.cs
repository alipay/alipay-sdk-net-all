using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementDelegationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementDelegationQueryModel : AopObject
    {
        /// <summary>
        /// AI付协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 代买委托id
        /// </summary>
        [XmlElement("delegation_id")]
        public string DelegationId { get; set; }

        /// <summary>
        /// AI付外部签约号
        /// </summary>
        [XmlElement("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 外部代买委托id
        /// </summary>
        [XmlElement("external_delegation_id")]
        public string ExternalDelegationId { get; set; }
    }
}
