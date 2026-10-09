using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeBusinessOrderConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeBusinessOrderConfirmModel : AopObject
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
        /// 请求流水号，表示外部一次请求，幂等字段
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
