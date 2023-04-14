using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantIndirectCollectionListDataRefundRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantIndirectCollectionListDataRefundRecord : AopObject
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 原始交易订单号 如有退款 必填
        /// </summary>
        [XmlElement("origin_order_no")]
        public string OriginOrderNo { get; set; }

        /// <summary>
        /// 退款渠道 ALIPAY 支付宝 WECHAT_PAY 微信支付 UNION_PAY 银联支付 OTHER 其他付款方式
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 退款交易状态 SUCCESS/FAIL
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
