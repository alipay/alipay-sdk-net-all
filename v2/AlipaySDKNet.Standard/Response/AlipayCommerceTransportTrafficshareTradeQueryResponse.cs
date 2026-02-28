using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTrafficshareTradeQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTrafficshareTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 金额单位
        /// </summary>
        [XmlElement("amount_unit")]
        public string AmountUnit { get; set; }

        /// <summary>
        /// 平台优惠金额。单位：取自amount_unit ，元或者分
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 商户业务号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 用户实际支付金额。单位：取自amount_unit ，元或者分
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 实收金额。该金额为本笔交易，商户账户能够实际收到的金额。单位：取自amount_unit ，元或者分
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 交易的订单金额，该参数的值为支付时传入的total_amount。单位：取自amount_unit ，元或者分
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
