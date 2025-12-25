using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderPayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderPayQueryModel : AopObject
    {
        /// <summary>
        /// 买家支付宝用户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号，由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 订单支付时传入的商家订单号,和支付宝交易号不能同时为空。 trade_no,out_trade_no如果同时存在优先取trade_no
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝交易号，和商家订单号不能同时为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
