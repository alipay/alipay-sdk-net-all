using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyTradeRefundResponse.
    /// </summary>
    public class MybankEcnyTradeRefundResponse : AopResponse
    {
        /// <summary>
        /// 本次退款是否发生了资金变化：Y-是；N-否
        /// </summary>
        [XmlElement("fund_change")]
        public string FundChange { get; set; }

        /// <summary>
        /// 调用方订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款总金额。指该笔交易累计已经退款成功的金额。
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 运营机构交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
