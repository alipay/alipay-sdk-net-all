using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingEquityBudgetQueryResponse.
    /// </summary>
    public class AnttechMorseMarketingEquityBudgetQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益剩余预算，单位为分
        /// </summary>
        [XmlElement("remaining_budget")]
        public long RemainingBudget { get; set; }

        /// <summary>
        /// 权益总预算，单位为分
        /// </summary>
        [XmlElement("total_budget")]
        public long TotalBudget { get; set; }
    }
}
