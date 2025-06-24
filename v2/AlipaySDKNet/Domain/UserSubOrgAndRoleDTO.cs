using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserSubOrgAndRoleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserSubOrgAndRoleDTO : AopObject
    {
        /// <summary>
        /// 成员id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 组织名
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }
    }
}
