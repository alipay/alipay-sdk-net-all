using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DelegationExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DelegationExtInfo : AopObject
    {
        /// <summary>
        /// 客户端ip
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 用户发现使用token
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }

        /// <summary>
        /// 用于用发现类型
        /// </summary>
        [XmlElement("user_token_type")]
        public string UserTokenType { get; set; }
    }
}
