using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMembersCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMembersCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝登录账号。
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 为成员添加的角色类型，支持： DEVELOPER-开发者； EXPERIENCER-体验者。
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
