using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardRefundDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardRefundDetail : AopObject
    {
        /// <summary>
        /// 充值余额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 充值订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 充值本金余额
        /// </summary>
        [XmlElement("principal_balance")]
        public string PrincipalBalance { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [XmlElement("record_time")]
        public string RecordTime { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款权益金金额
        /// </summary>
        [XmlElement("refund_benefit_amount")]
        public string RefundBenefitAmount { get; set; }

        /// <summary>
        /// 扣减权益金已优惠金额
        /// </summary>
        [XmlElement("subtract_benefit_amount")]
        public string SubtractBenefitAmount { get; set; }

        /// <summary>
        /// 扣减已优惠金额
        /// </summary>
        [XmlElement("subtract_discount_amount")]
        public string SubtractDiscountAmount { get; set; }

        /// <summary>
        /// 扣减券已优惠金额
        /// </summary>
        [XmlElement("subtract_voucher_amount")]
        public string SubtractVoucherAmount { get; set; }
    }
}
