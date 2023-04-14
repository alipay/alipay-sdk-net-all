using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderRefundModel : AopObject
    {
        /// <summary>
        /// 用户open_id,和user_id二选一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。order_id、out_order_id，二选一
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 商户自定义退款流水id,标识一次退款请求，需要保证在交易号下唯一。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_refund_id")]
        public string OutRefundId { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund")]
        public string Refund { get; set; }

        /// <summary>
        /// 退款原因说明。 商家自定义，将在会在商户和用户的pc退款账单详情中展示
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 用户UID（与openId二选一）
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
