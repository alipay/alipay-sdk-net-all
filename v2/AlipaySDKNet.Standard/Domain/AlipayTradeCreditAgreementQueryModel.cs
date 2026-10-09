using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCreditAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCreditAgreementQueryModel : AopObject
    {
        /// <summary>
        /// 先采协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 商户外部协议号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }
    }
}
