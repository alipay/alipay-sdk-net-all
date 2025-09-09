using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourVoucherInfoQueryopenapiResult Data Structure.
    /// </summary>
    [Serializable]
    public class TourVoucherInfoQueryopenapiResult : AopObject
    {
        /// <summary>
        /// 有效期结束时间
        /// </summary>
        [XmlElement("effective_time_end")]
        public string EffectiveTimeEnd { get; set; }

        /// <summary>
        /// 凭证有效期开始时间
        /// </summary>
        [XmlElement("effective_time_start")]
        public string EffectiveTimeStart { get; set; }

        /// <summary>
        /// 凭证实际核销时间
        /// </summary>
        [XmlElement("exp_date")]
        public string ExpDate { get; set; }

        /// <summary>
        /// 商品库商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款订单ID
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 凭证状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝凭证ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
