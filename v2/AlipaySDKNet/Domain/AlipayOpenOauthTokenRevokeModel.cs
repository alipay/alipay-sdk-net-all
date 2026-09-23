using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOauthTokenRevokeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOauthTokenRevokeModel : AopObject
    {
        /// <summary>
        /// 访问令牌。通过该访问令牌调用支付宝开放平台
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 智能体调用场景，此字段必填，并严格匹配与访问令牌（access_token）的归属关系
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }
    }
}
