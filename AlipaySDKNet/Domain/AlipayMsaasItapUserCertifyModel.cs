using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasItapUserCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasItapUserCertifyModel : AopObject
    {
        /// <summary>
        /// 用户认证消息体
        /// </summary>
        [XmlArray("payload")]
        [XmlArrayItem("user_certify_payload")]
        public List<UserCertifyPayload> Payload { get; set; }

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
