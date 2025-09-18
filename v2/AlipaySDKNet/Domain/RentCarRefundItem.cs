using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarRefundItem Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarRefundItem : AopObject
    {
        /// <summary>
        /// 用于对账，对应业务账单中的商家订单号字段
        /// </summary>
        [XmlElement("bill_merchant_order_id")]
        public string BillMerchantOrderId { get; set; }

        /// <summary>
        /// 用于对账，对应业务账单中的退款批次号字段
        /// </summary>
        [XmlElement("bill_refund_batch_no")]
        public string BillRefundBatchNo { get; set; }

        /// <summary>
        /// 当前退款请求在此支付流水中退款的金额，单位分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 当前退款请求在此支付流水中退款的结果
        /// </summary>
        [XmlElement("refund_result")]
        public string RefundResult { get; set; }

        /// <summary>
        /// 支付流水的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
