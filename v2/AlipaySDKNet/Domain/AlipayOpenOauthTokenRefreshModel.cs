using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOauthTokenRefreshModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOauthTokenRefreshModel : AopObject
    {
        /// <summary>
        /// 智能体调用场景，此字段必填，并严格匹配与刷新令牌（refresh_token）的归属关系
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 刷新令牌，用于换取新的访问令牌
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
