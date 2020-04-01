using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiTradeOrderAggregateConsultResponse.
    /// </summary>
    public class KoubeiTradeOrderAggregateConsultResponse : AopResponse
    {
        /// <summary>
        /// 买家ID, 支付成功时才返回
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 付款用户类型； 支付宝(alipay)/微信(weixin)，支付成功时才返回
        /// </summary>
        [XmlElement("buyer_id_type")]
        public string BuyerIdType { get; set; }

        /// <summary>
        /// 用户实付金额，支付成功时才返回
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 本交易支付时使用的所有优惠券信息
        /// </summary>
        [XmlElement("discount_detail_list")]
        public DiscountDetailInfo DiscountDetailList { get; set; }

        /// <summary>
        /// 支付成功时间
        /// </summary>
        [XmlElement("gmt_payment_time")]
        public string GmtPaymentTime { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [XmlElement("merchant_discount_amount")]
        public string MerchantDiscountAmount { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// SUCCESS - 支付成功 FAILED - 支付失败 PROCESSING - 处理中 CLOSED - 关单
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商家请求订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付渠道； 支付宝(alipay)/微信(wechat)
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 平台优惠金额
        /// </summary>
        [XmlElement("platform_discount_amount")]
        public string PlatformDiscountAmount { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝/微信交易号； 支付成功时才返回
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
