using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSubscriptionCreateResponse.
    /// </summary>
    public class AlipayTradeSubscriptionCreateResponse : AopResponse
    {
        /// <summary>
        /// alipay_schema
        /// </summary>
        [XmlElement("alipay_schema")]
        public string AlipaySchema { get; set; }

        /// <summary>
        /// 支付金额，单位分
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 订阅id
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
