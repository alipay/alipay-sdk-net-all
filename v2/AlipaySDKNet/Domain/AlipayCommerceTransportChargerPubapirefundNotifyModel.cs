using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerPubapirefundNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerPubapirefundNotifyModel : AopObject
    {
        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单退款金额，单位：元，两位小数
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款订单号,调用方传入,调用方生成,确保唯一
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 订单的退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款结果说明pending-退款中；success-退款成功；failed-退款失败；
        /// </summary>
        [XmlElement("refund_result")]
        public string RefundResult { get; set; }

        /// <summary>
        /// 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("start_charge_seq")]
        public string StartChargeSeq { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
