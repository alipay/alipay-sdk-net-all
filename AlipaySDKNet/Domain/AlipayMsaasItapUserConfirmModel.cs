using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasItapUserConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasItapUserConfirmModel : AopObject
    {
        /// <summary>
        /// 用户确认消息体
        /// </summary>
        [XmlArray("payload")]
        [XmlArrayItem("user_confirm_payload")]
        public List<UserConfirmPayload> Payload { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
