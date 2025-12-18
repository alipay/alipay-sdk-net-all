using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardRedeemRefundResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardRedeemRefundResponse : AopResponse
    {
        /// <summary>
        /// 实际退款金额（单位：分）
        /// </summary>
        [XmlElement("actual_refund_amount")]
        public string ActualRefundAmount { get; set; }

        /// <summary>
        /// 退核销订单号
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 原核销订单号
        /// </summary>
        [XmlElement("original_deduction_order_id")]
        public string OriginalDeductionOrderId { get; set; }

        /// <summary>
        /// 退款结果说明
        /// </summary>
        [XmlElement("refund_remark")]
        public string RefundRemark { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款完成时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 本次退款核销的交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
