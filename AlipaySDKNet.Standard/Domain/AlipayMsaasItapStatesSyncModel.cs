using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasItapStatesSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasItapStatesSyncModel : AopObject
    {
        /// <summary>
        /// 状态同步消息体
        /// </summary>
        [XmlArray("payload")]
        [XmlArrayItem("states_sync_payload")]
        public List<StatesSyncPayload> Payload { get; set; }

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
