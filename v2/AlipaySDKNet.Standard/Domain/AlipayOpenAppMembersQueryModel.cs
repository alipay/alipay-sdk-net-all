using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMembersQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMembersQueryModel : AopObject
    {
        /// <summary>
        /// 查询的成员角色类型。 枚举支持： DEVELOPER：开发者； EXPERIENCER：体验者。 请选择其一传入
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
