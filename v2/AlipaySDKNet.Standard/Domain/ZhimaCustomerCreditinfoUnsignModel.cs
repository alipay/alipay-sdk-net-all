using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerCreditinfoUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerCreditinfoUnsignModel : AopObject
    {
        /// <summary>
        /// 商户外部单号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }
    }
}
