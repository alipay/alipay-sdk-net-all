using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletRuleQueryResponse.
    /// </summary>
    public class AlipayFundWalletRuleQueryResponse : AopResponse
    {
        /// <summary>
        /// 钱包使用规则
        /// </summary>
        [XmlElement("wallet_use_rule")]
        public WalletUseRule WalletUseRule { get; set; }
    }
}
