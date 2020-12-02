using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMembersDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMembersDeleteModel : AopObject
    {
        /// <summary>
        /// 被删除成员的角色类型，枚举支持： DEVELOPER：开发者。 EXPERIENCER：体验者。
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 被删除成员的支付宝账户唯一标识，以2088开头。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
