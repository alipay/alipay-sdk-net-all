using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflinePaysaasOrderQueryResponse.
    /// </summary>
    public class AlipayOfflinePaysaasOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 推单业务的唯一单号
        /// </summary>
        [XmlElement("isv_order_no")]
        public string IsvOrderNo { get; set; }

        /// <summary>
        /// 收款订单状态，用于服务商收银机展示收款状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 推单对应的支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }
    }
}
