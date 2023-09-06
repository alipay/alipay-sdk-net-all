using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarCommercializationOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCommercializationOrderRefundModel : AopObject
    {
        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家侧订单id，订单的唯一标识
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 退款流水号，退款请求唯一标识
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 退款的凭证明细列表，如果不传，则表明是业务订单整体退款。如果支付宝侧发现凭证已经使用（冻结和核销），则直接失败
        /// </summary>
        [XmlArray("refund_certificate_list")]
        [XmlArrayItem("commercialization_certificate_info")]
        public List<CommercializationCertificateInfo> RefundCertificateList { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
