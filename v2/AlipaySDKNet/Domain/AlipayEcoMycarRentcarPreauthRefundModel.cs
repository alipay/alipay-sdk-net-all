using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarPreauthRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarPreauthRefundModel : AopObject
    {
        /// <summary>
        /// 扣款时的外部交易号。一笔预授权可能有多笔扣款，退款是基于扣款去退的，因此要传扣款时的交易号
        /// </summary>
        [XmlElement("deduct_out_trade_no")]
        public string DeductOutTradeNo { get; set; }

        /// <summary>
        /// 支付宝用户开放平台id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退款金额，单位分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 退款外部请求号，通过此字段对退款请求进行幂等控制
        /// </summary>
        [XmlElement("refund_out_request_no")]
        public string RefundOutRequestNo { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
