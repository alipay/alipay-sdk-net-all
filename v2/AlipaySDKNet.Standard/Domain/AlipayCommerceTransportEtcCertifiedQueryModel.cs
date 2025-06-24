using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcCertifiedQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcCertifiedQueryModel : AopObject
    {
        /// <summary>
        /// 授权协议号
        /// </summary>
        [XmlElement("auth_agreement_no")]
        public string AuthAgreementNo { get; set; }
    }
}
