using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOauthTokenGrantModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOauthTokenGrantModel : AopObject
    {
        /// <summary>
        /// 智能体调用场景，此字段必填，并严格匹配与授权码（auth_code）的归属关系
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 授权码，用户授权后得到。
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }
    }
}
