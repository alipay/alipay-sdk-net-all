using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceTradeRefundResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceTradeRefundResponse : AopResponse
    {
        /// <summary>
        /// 用户的登录id
        /// </summary>
        [XmlElement("buyer_login_id")]
        public string BuyerLoginId { get; set; }

        /// <summary>
        /// 买家在支付宝的用户ID
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 退款支付时间，格式："yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 用户本次退款成功的总金额
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
