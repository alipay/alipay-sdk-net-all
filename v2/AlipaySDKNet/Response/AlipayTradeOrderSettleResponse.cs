using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeOrderSettleResponse.
    /// </summary>
    public class AlipayTradeOrderSettleResponse : AopResponse
    {
        /// <summary>
        /// 支付宝分账单号，可以根据该单号查询单次分账请求执行结果
        /// </summary>
        [XmlElement("settle_no")]
        public string SettleNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
