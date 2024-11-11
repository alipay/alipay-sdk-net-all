using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 该订单已产生的业务消息
        /// </summary>
        [XmlArray("biz_order_message_list")]
        [XmlArrayItem("biz_order_message")]
        public List<BizOrderMessage> BizOrderMessageList { get; set; }

        /// <summary>
        /// 机构订单号
        /// </summary>
        [XmlElement("inst_order_id")]
        public string InstOrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单成功
        /// </summary>
        [XmlElement("order_status_code")]
        public string OrderStatusCode { get; set; }
    }
}
