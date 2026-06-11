using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfimMqSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfimMqSyncModel : AopObject
    {
        /// <summary>
        /// 同步信息，接口不反序列化此字段，直接透传到SOFAMQ
        /// </summary>
        [XmlElement("msg_body")]
        public string MsgBody { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// RabbitMQ routing key，用于路由消息到对应的SOFAMQ topic。支持精确匹配和前缀匹配，例如 sendGroupMessage.BaseFlow.doctor.text.success 会匹配到 sendGroupMessage 前缀
        /// </summary>
        [XmlElement("routing_key")]
        public string RoutingKey { get; set; }
    }
}
