using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingBenefitaccountAccountCreateResponse.
    /// </summary>
    public class AlipayMarketingBenefitaccountAccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 权益账户号
        /// </summary>
        [XmlElement("benefit_account_no")]
        public string BenefitAccountNo { get; set; }
    }
}
