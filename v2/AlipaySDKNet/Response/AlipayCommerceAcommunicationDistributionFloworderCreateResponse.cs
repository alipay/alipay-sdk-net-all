using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionFloworderCreateResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionFloworderCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单id
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 权益到账的用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 机构订单id
        /// </summary>
        [XmlElement("inst_order_id")]
        public string InstOrderId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
