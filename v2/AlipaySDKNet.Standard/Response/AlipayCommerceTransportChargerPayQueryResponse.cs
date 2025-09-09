using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerPayQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerPayQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务订单详情信息
        /// </summary>
        [XmlElement("charger_order_info")]
        public ChargerOrderInfo ChargerOrderInfo { get; set; }

        /// <summary>
        /// 商户同步优惠金额。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("merchant_discount_amount")]
        public string MerchantDiscountAmount { get; set; }

        /// <summary>
        /// 商户同步支付金额。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("merchant_pay_amount")]
        public string MerchantPayAmount { get; set; }

        /// <summary>
        /// 商户同步订单总金额。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("merchant_total_amount")]
        public string MerchantTotalAmount { get; set; }

        /// <summary>
        /// 行业支付订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 订单类型。PNC（即插即充）、NORMAL（普通订单）
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝侧交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 实际交易信息
        /// </summary>
        [XmlElement("trade_settle_info")]
        public ChargerTradeSettleInfo TradeSettleInfo { get; set; }

        /// <summary>
        /// 订单交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
