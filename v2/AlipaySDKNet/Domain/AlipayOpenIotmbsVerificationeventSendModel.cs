using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsVerificationeventSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsVerificationeventSendModel : AopObject
    {
        /// <summary>
        /// 业务事件，唯一标识一个具体的业务事件。由对接业务的支付宝产品负责人提供。
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }

        /// <summary>
        /// 展现在用户侧的业务信息。
        /// </summary>
        [XmlElement("event_params")]
        public string EventParams { get; set; }

        /// <summary>
        /// 唯一标识事件流，例如订单号。与支付宝业务对接人沟通是否需要填写
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 用户刷脸核身的唯一标识
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 请求id，用作幂等。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 刷脸设备的唯一标识
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
