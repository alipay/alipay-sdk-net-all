using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyTradeCancelResponse.
    /// </summary>
    public class MybankEcnyTradeCancelResponse : AopResponse
    {
        /// <summary>
        /// 本次撤销触发的交易动作,接口调用成功且交易存在时返回。可能的返回值： close：交易未支付，触发关闭交易动作，无退款； refund：交易已支付，触发交易退款动作； 未返回：未查询到交易，或接口调用失败；
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 调用方订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 重试标志： Y-需要重试；N-不需要重试
        /// </summary>
        [XmlElement("retry_flag")]
        public string RetryFlag { get; set; }

        /// <summary>
        /// 运营机构交易号; 当发生交易关闭或交易退款时返回；
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
