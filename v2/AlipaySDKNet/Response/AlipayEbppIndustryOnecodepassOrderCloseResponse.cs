using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryOnecodepassOrderCloseResponse.
    /// </summary>
    public class AlipayEbppIndustryOnecodepassOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝交易号; 当发生交易关闭或交易退款时返回
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
