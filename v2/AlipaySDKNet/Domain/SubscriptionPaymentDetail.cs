using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionPaymentDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionPaymentDetail : AopObject
    {
        /// <summary>
        /// 事件发生时间，针对subscription_create、subscription_upgrade、subscription_cycle为支付成功时间；subscription_refund为立即取消的请求时间（退款为异步退款），实际退款时间可以参考refund_details退款明细中的refund_time
        /// </summary>
        [XmlElement("gmt_occur")]
        public string GmtOccur { get; set; }

        /// <summary>
        /// 订阅支付单号/退款单号。正向支付时，order_no为subscription_create、subscription_upgrade、subscription_cycle对应的order_no；逆向退款时order_no为取消接口返回的refund_order_id
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("refund_details")]
        [XmlArrayItem("subscription_batch_refund_detail")]
        public List<SubscriptionBatchRefundDetail> RefundDetails { get; set; }

        /// <summary>
        /// 总支付或退款金额，单位元。注意当pay_type= subscription_refund时，该字段代表总退款金额，实际退款金额以refund_details中退款成功的金额为准
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 交易单号。注意当pay_type= subscription_refund时，无该字段，退款可能涉及到多笔订单的退款，退款的交易明细可以通过refund_details确认
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
