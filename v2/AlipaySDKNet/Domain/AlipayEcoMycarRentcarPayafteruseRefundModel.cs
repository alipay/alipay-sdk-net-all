using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarPayafteruseRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarPayafteruseRefundModel : AopObject
    {
        /// <summary>
        /// 扣款时的商户交易号
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
        /// 退款外部请求号，即商户请求车生活发起先享后付退款的流水号，车生活侧通过此字段进行幂等
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
