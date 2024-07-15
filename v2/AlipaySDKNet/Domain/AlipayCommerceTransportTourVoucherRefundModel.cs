using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTourVoucherRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTourVoucherRefundModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家側退款订单ID流水号
        /// </summary>
        [XmlElement("out_refund_id")]
        public string OutRefundId { get; set; }

        /// <summary>
        /// 外部凭证id列表，传商側凭证id
        /// </summary>
        [XmlArray("out_voucher_list")]
        [XmlArrayItem("string")]
        public List<string> OutVoucherList { get; set; }

        /// <summary>
        /// 订单退款金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund")]
        public string Refund { get; set; }

        /// <summary>
        /// 用户退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
