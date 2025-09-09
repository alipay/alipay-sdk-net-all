using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerCreditinfoAuthawardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerCreditinfoAuthawardQueryModel : AopObject
    {
        /// <summary>
        /// 商户外部协议号，不同的支付宝用户需要传递不同的外部单号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }
    }
}
