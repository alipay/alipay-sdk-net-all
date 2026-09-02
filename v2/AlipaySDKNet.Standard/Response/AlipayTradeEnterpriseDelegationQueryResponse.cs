using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeEnterpriseDelegationQueryResponse.
    /// </summary>
    public class AlipayTradeEnterpriseDelegationQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付交易号 
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
