using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryOnecodepassOrderRefundResponse.
    /// </summary>
    public class AlipayEbppIndustryOnecodepassOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 本次退款是否发生了资金变化，Y 为发生变化
        /// </summary>
        [XmlElement("fund_status")]
        public string FundStatus { get; set; }

        /// <summary>
        /// 当前退款金额。
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
