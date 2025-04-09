using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsCbddoctorMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsCbddoctorMessageSendModel : AopObject
    {
        /// <summary>
        /// 互医生成的msgId。需要唯一，用于防止消息发送重复。
        /// </summary>
        [XmlElement("client_msg_id")]
        public string ClientMsgId { get; set; }

        /// <summary>
        /// 问诊对话消息体
        /// </summary>
        [XmlElement("message")]
        public CBDMessageBody Message { get; set; }

        /// <summary>
        /// 蚂蚁服务工单编号
        /// </summary>
        [XmlElement("service_order_id")]
        public string ServiceOrderId { get; set; }
    }
}
