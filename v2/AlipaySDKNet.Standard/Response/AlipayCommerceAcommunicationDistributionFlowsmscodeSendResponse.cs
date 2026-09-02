using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionFlowsmscodeSendResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionFlowsmscodeSendResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单id
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }
    }
}
