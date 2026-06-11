using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeEnterpriseDelegationPayResponse.
    /// </summary>
    public class AlipayTradeEnterpriseDelegationPayResponse : AopResponse
    {
        /// <summary>
        /// 支付成功的交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
