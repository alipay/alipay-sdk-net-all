using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardRedeemRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardRedeemRefundModel : AopObject
    {
        /// <summary>
        /// 售卖订单id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 核销订单号
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 退款流水号标识一次退款请求，需要保证在订单号下唯一。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款流水号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款流水号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退卡金额（单位：分）
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因说明。
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
