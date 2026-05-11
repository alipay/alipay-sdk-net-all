using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceResaleOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceResaleOrderRefundModel : AopObject
    {
        /// <summary>
        /// 用户支付宝id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 外部退款流水号， 确保在订单粒度下全局唯一，重复输入会幂等返回
        /// </summary>
        [XmlElement("out_refund_id")]
        public string OutRefundId { get; set; }

        /// <summary>
        /// 部分退款场景才需要传入
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 全额退款：FULL_REFUND，当前只支持全额退款
        /// </summary>
        [XmlElement("refund_amount_type")]
        public string RefundAmountType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("refund_memo")]
        public string RefundMemo { get; set; }

        /// <summary>
        /// 需要退款的发起支付的支付流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 用户支付宝id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
