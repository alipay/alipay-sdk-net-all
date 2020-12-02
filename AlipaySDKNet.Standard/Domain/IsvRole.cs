using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvRole Data Structure.
    /// </summary>
    [Serializable]
    public class IsvRole : AopObject
    {
        /// <summary>
        /// isv定义的角色的唯一标识
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// isv定义的角色名称
        /// </summary>
        [XmlElement("role_name")]
        public string RoleName { get; set; }
    }
}
