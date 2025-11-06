using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingFundschemeBudgetQueryResponse.
    /// </summary>
    public class AlipayMarketingFundschemeBudgetQueryResponse : AopResponse
    {
        /// <summary>
        /// 剩余预算，余额单位元
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 请求入参的资金池id，资金池的唯一索引
        /// </summary>
        [XmlElement("fund_scheme_id")]
        public string FundSchemeId { get; set; }

        /// <summary>
        /// 配置总预算金额，单位元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
