using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCreditRefundResponse.
    /// </summary>
    public class AlipayTradeCreditRefundResponse : AopResponse
    {
        /// <summary>
        /// 信用订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 退款成功时间
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 退款成功金额，单位：元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款的支付宝交易订单号，便于商家对账使用
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
