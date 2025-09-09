using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBenefitaccountAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBenefitaccountAccountQueryModel : AopObject
    {
        /// <summary>
        /// 权益账户账户号
        /// </summary>
        [XmlElement("benefit_account_no")]
        public string BenefitAccountNo { get; set; }

        /// <summary>
        /// 创建人用户ID
        /// </summary>
        [XmlElement("publisher_user_id")]
        public string PublisherUserId { get; set; }
    }
}
