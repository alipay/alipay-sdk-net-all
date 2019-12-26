using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingExperienceAccountQueryResponse.
    /// </summary>
    public class AlipayInsMarketingExperienceAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 剩余可提现收益
        /// </summary>
        [XmlElement("remaining_profit")]
        public string RemainingProfit { get; set; }

        /// <summary>
        /// 体验金总额
        /// </summary>
        [XmlElement("total_experience_amount")]
        public string TotalExperienceAmount { get; set; }
    }
}
