using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWithholdrepayorderTradeCancelResponse.
    /// </summary>
    public class AlipayCommerceWithholdrepayorderTradeCancelResponse : AopResponse
    {
        /// <summary>
        /// 本次撤销触发的交易动作,接口调用成功且交易存在时返回。可能的返回值： close：交易未支付，触发关闭交易动作，无退款； refund：交易已支付，触发交易退款动作； 未返回：未查询到交易，或接口调用失败；
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 当撤销产生了退款时，返回退款时间； 只在银行间联交易场景下返回该信息
        /// </summary>
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 当撤销产生了退款时，返回的退款清算编号，用于清算对账使用； 只在银行间联交易场景下返回该信息
        /// </summary>
        [XmlElement("refund_settlement_id")]
        public string RefundSettlementId { get; set; }

        /// <summary>
        /// 是否需要重试，Y为需要，N为不需要
        /// </summary>
        [XmlElement("retry_flag")]
        public string RetryFlag { get; set; }

        /// <summary>
        /// 支付宝交易号; 当发生交易关闭或交易退款时返回
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
