using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcFundStrategyCreateResponse.
    /// </summary>
    public class AlipayCommerceEcFundStrategyCreateResponse : AopResponse
    {
        /// <summary>
        /// 出资账户唯一编号
        /// </summary>
        [XmlElement("fund_account_id")]
        public string FundAccountId { get; set; }

        /// <summary>
        /// 出资账户类型
        /// </summary>
        [XmlElement("fund_account_type")]
        public string FundAccountType { get; set; }

        /// <summary>
        /// 出资方式名称，不填写时，系统会自动生成
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 出资方式唯一标识
        /// </summary>
        [XmlElement("strategy_id")]
        public string StrategyId { get; set; }
    }
}
