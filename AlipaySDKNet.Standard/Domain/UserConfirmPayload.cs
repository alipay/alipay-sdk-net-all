using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserConfirmPayload Data Structure.
    /// </summary>
    [Serializable]
    public class UserConfirmPayload : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 用户校验token
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }
    }
}
