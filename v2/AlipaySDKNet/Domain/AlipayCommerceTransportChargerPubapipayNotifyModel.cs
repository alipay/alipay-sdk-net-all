using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerPubapipayNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerPubapipayNotifyModel : AopObject
    {
        /// <summary>
        /// 用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单支付金额，单位：元，两位小数
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单支付结果。success-支付成功；failed-支付失败；timeout-支付超时
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 商户侧订单id，全局唯一；与互联互通的订单号保持一致
        /// </summary>
        [XmlElement("start_charge_seq")]
        public string StartChargeSeq { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
