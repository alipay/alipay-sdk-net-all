using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementDelegationCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementDelegationCancelModel : AopObject
    {
        /// <summary>
        /// AI付协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 代买委托号
        /// </summary>
        [XmlElement("delegation_id")]
        public string DelegationId { get; set; }
    }
}
