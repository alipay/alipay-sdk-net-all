using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderExternalPaychannelSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderExternalPaychannelSyncModel : AopObject
    {
        /// <summary>
        /// isv侧的业务订单号，等同于支付接口spi.alipay.merchant.order.commonisv.pay 中的isv_order_no
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务单状态
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 买家实付金额 - 仅针对支付
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 平台优惠金额 - 仅针对支付
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道
        /// </summary>
        [XmlElement("fund_bill_list")]
        public string FundBillList { get; set; }

        /// <summary>
        /// 支付成功时间 - 仅针对支付
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 商家优惠金额 - 仅针对支付
        /// </summary>
        [XmlElement("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 通知时间
        /// </summary>
        [XmlElement("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 原始第三方支付结构的交易号，比如支付宝、微信交易号。等同于支付接口spi.alipay.merchant.order.commonisv.pay 中的channel_order_no
        /// </summary>
        [XmlElement("origin_trade_no")]
        public string OriginTradeNo { get; set; }

        /// <summary>
        /// 外部业务号，等同于支付接口spi.alipay.merchant.order.commonisv.pay中的merchant_order_no
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部请求号 - 仅针对退款
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付通道类型，001：支付宝，002：微信，003：qq钱包，004：京东钱包，005：口碑，006：翼支付，007：银联二维码，008：和包支付（仅限和包通道），009：百度钱包，010：苏宁钱包，100：自动识别类型等
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 实收金额 - 仅针对支付
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 本次退款金额（非累计） - 仅针对退款
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 累计退款总金额 - 仅针对退款
        /// </summary>
        [XmlElement("refund_total_amount")]
        public string RefundTotalAmount { get; set; }

        /// <summary>
        /// 业务单总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
