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

        /// <summary>
        /// 外标打款卡号
        /// </summary>
        [XmlElement("out_card_no")]
        public string OutCardNo { get; set; }
    }
}
