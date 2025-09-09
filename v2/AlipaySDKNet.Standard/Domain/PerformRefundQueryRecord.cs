using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PerformRefundQueryRecord Data Structure.
    /// </summary>
    [Serializable]
    public class PerformRefundQueryRecord : AopObject
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务受理平台业务28位订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 退款完成时间
        /// </summary>
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 支付单号
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 实退金额,如果支付用了优惠券，实际退款金额和退款金额会不一样
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 单据退款原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 退收费金额
        /// </summary>
        [XmlElement("refund_charge_fee")]
        public string RefundChargeFee { get; set; }

        /// <summary>
        /// 退款单失败状态明细
        /// </summary>
        [XmlElement("refund_error_info")]
        public string RefundErrorInfo { get; set; }

        /// <summary>
        /// 退款请求号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// I 退款受理 P 退款中 S 退款成功 F 退款失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
