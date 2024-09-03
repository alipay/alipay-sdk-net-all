using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiAgentServiceConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiAgentServiceConsultModel : AopObject
    {
        /// <summary>
        /// 用户标识ID。不同用户下的会话是隔离的，互不影响。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 硬件设备信息
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 提问的消息体
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 请求的唯一标识，同一个serviceId下，不同请求的requestId需要唯一
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务场景标识，对应不同的服务场景，每个服务场景对应不同的配置，如访问的大模型类型、版本、依赖的知识库等等
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 如果客户端有显示的会话管理功能，可以传会话ID，不同会话的上下文是隔离的。如果终端没有会话管理功能，可以不传。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 是否流式响应
        /// </summary>
        [XmlElement("stream")]
        public bool Stream { get; set; }
    }
}
