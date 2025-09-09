using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserOrgAndRoleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserOrgAndRoleDTO : AopObject
    {
        /// <summary>
        /// 组织成员ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 组织ID
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 用户通行证ID
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 用户所属组织角色
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 用户子组织角色信息
        /// </summary>
        [XmlArray("user_sub_org_and_role_list")]
        [XmlArrayItem("user_sub_org_and_role_d_t_o")]
        public List<UserSubOrgAndRoleDTO> UserSubOrgAndRoleList { get; set; }
    }
}
