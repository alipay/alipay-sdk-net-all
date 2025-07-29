using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCreditOrderQueryResponse.
    /// </summary>
    public class AlipayTradeCreditOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 信用服务订单中的垫资金额。
        /// </summary>
        [XmlElement("advance_total_fee")]
        public string AdvanceTotalFee { get; set; }

        /// <summary>
        /// 信用支付履约时间
        /// </summary>
        [XmlElement("buyer_pay_time")]
        public string BuyerPayTime { get; set; }

        /// <summary>
        /// 信用服务订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 信用服务订单中信用支付金额，不包含支付宝营销金额
        /// </summary>
        [XmlElement("credit_pay_fee")]
        public string CreditPayFee { get; set; }

        /// <summary>
        /// 信用支付额度确认时间
        /// </summary>
        [XmlElement("credit_quota_confirm_time")]
        public string CreditQuotaConfirmTime { get; set; }

        /// <summary>
        /// 信用支付时间
        /// </summary>
        [XmlElement("credit_quota_pay_time")]
        public string CreditQuotaPayTime { get; set; }

        /// <summary>
        /// 信用支付退款金额
        /// </summary>
        [XmlElement("credit_refund_fee")]
        public string CreditRefundFee { get; set; }

        /// <summary>
        /// 信用服务订单中的订单金额，包含营销。
        /// </summary>
        [XmlElement("credit_total_fee")]
        public string CreditTotalFee { get; set; }

        /// <summary>
        /// 信用支付垫资时间
        /// </summary>
        [XmlElement("guarantee_pay_time")]
        public string GuaranteePayTime { get; set; }

        /// <summary>
        /// 发起信用支付时的外部交易单号。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 信用支付逾期时间
        /// </summary>
        [XmlElement("overdue_time")]
        public string OverdueTime { get; set; }

        /// <summary>
        /// 信用订单的状态信息。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 信用支付的交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
