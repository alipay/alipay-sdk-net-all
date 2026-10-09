using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeBusinessOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeBusinessOrderRefundModel : AopObject
    {
        /// <summary>
        /// 金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种，不传默认CNY
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 创建订单时返回的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款类型 REFUND（售中退款） POST_REFUND (售后退款) 不传默认用REFUND
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求流水号，表示外部一次请求，幂等字段
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
