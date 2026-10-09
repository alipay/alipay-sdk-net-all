using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeOverdraftReturnmoneyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeOverdraftReturnmoneyModel : AopObject
    {
        /// <summary>
        /// 追款请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一。与支付宝交易号 trade_no 不能同时为空。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款时上传的外部请求号。仅特定商户可选
        /// </summary>
        [XmlElement("refund_out_request_no")]
        public string RefundOutRequestNo { get; set; }

        /// <summary>
        /// 支付宝交易号。 和商户订单号 out_trade_no 不能同时为空。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
