using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderPayCancelResponse.
    /// </summary>
    public class AlipayCommerceRentOrderPayCancelResponse : AopResponse
    {
        /// <summary>
        /// 交易组件业务订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 租金支付外部请求号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次支付请求的金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }
    }
}
