using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarRentcarPayafterusePayResponse.
    /// </summary>
    public class AlipayEcoMycarRentcarPayafterusePayResponse : AopResponse
    {
        /// <summary>
        /// 此次扣款产生的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
