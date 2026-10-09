using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrderCreateResponse.
    /// </summary>
    public class AlipayMarketingActivityOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 购买商家兑换券的营销订单号。  主要用于后续的退款等操作。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务订单号。 同时具备幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝交易号。 用于后续的交易支付。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
