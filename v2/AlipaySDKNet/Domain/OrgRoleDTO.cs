using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrgRoleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrgRoleDTO : AopObject
    {
        /// <summary>
        /// 树节点
        /// </summary>
        [XmlElement("node")]
        public OrgNodeDTO Node { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 用户列表
        /// </summary>
        [XmlArray("user_list")]
        [XmlArrayItem("user_d_t_o")]
        public List<UserDTO> UserList { get; set; }
    }
}
