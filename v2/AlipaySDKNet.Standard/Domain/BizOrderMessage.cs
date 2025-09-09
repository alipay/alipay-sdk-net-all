using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizOrderMessage Data Structure.
    /// </summary>
    [Serializable]
    public class BizOrderMessage : AopObject
    {
        /// <summary>
        /// message_type = PHONECARD_SHIPMENT 时为物流单号； message_type = BROAD_BAND_COMPLETE 时为宽带号；
        /// </summary>
        [XmlElement("biz_flow_id")]
        public string BizFlowId { get; set; }

        /// <summary>
        /// message_type = PHONECARD_SHIPMENT 时为物流商编码； message_type = PHONECARD_FIRST_TOPUP 时为充值金额，单位分；
        /// </summary>
        [XmlElement("biz_value")]
        public string BizValue { get; set; }

        /// <summary>
        /// 消息发送时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 消息唯一键
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// 业务消息
        /// </summary>
        [XmlElement("message_type")]
        public string MessageType { get; set; }
    }
}
