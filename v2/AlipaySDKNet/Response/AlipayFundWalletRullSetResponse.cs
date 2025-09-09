using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletRullSetResponse.
    /// </summary>
    public class AlipayFundWalletRullSetResponse : AopResponse
    {
        /// <summary>
        /// 钱包规则范围
        /// </summary>
        [XmlElement("wallet_use_rule")]
        public WalletUseRule WalletUseRule { get; set; }
    }
}
