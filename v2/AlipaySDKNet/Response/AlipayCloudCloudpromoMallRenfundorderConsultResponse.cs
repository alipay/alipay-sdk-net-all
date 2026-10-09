using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallRenfundorderConsultResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallRenfundorderConsultResponse : AopResponse
    {
        /// <summary>
        /// 支持的订单退货方式
        /// </summary>
        [XmlElement("biz_claim_type")]
        public string BizClaimType { get; set; }

        /// <summary>
        /// 本单最大可退款金额(单位：分)
        /// </summary>
        [XmlElement("max_refund_fee")]
        public string MaxRefundFee { get; set; }

        /// <summary>
        /// 本单最小可退款金额(单位：分)
        /// </summary>
        [XmlElement("min_refund_fee")]
        public long MinRefundFee { get; set; }

        /// <summary>
        /// 子分销订单号
        /// </summary>
        [XmlElement("order_line_id")]
        public string OrderLineId { get; set; }

        /// <summary>
        /// 逆向理由集合
        /// </summary>
        [XmlElement("refund_reason_list")]
        public MpcRefundReason RefundReasonList { get; set; }
    }
}
