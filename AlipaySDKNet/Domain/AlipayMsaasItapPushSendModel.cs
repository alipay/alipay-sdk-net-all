using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasItapPushSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasItapPushSendModel : AopObject
    {
        /// <summary>
        /// 设备消息通知消息体
        /// </summary>
        [XmlArray("payload")]
        [XmlArrayItem("device_push_payload")]
        public List<DevicePushPayload> Payload { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 对外使用的唯一用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
