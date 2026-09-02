using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvAuthResult Data Structure.
    /// </summary>
    [Serializable]
    public class IsvAuthResult : AopObject
    {
        /// <summary>
        /// 授权状态字段。
        /// </summary>
        [XmlElement("auth_status")]
        public bool AuthStatus { get; set; }

        /// <summary>
        /// 令牌有效期，单位s。
        /// </summary>
        [XmlElement("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌有效期，单位s。
        /// </summary>
        [XmlElement("re_expires_in")]
        public string ReExpiresIn { get; set; }
    }
}
