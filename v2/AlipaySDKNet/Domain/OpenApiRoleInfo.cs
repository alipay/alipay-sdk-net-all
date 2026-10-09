using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiRoleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiRoleInfo : AopObject
    {
        /// <summary>
        /// 角色类型
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 角色code
        /// </summary>
        [XmlElement("sub_role_type")]
        public string SubRoleType { get; set; }
    }
}
