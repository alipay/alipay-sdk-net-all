using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiTradeOrderRefundQueryResponse.
    /// </summary>
    public class KoubeiTradeOrderRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 退款成功时间
        /// </summary>
        [XmlElement("gmt_refund_time")]
        public string GmtRefundTime { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部退款单号
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 退款总金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 用户实退金额
        /// </summary>
        [XmlElement("refund_buyer_amount")]
        public string RefundBuyerAmount { get; set; }

        /// <summary>
        /// 退平台优惠金额
        /// </summary>
        [XmlElement("refund_discount_amount")]
        public string RefundDiscountAmount { get; set; }

        /// <summary>
        /// 退商家优惠金额
        /// </summary>
        [XmlElement("refund_mdiscount_amount")]
        public string RefundMdiscountAmount { get; set; }

        /// <summary>
        /// 退款单状态  SUCCESS - 成功 PROCESSING - 受理中 FAILED - 失败
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
