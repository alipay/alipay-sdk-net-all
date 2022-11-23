using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SimplePermissionRoleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SimplePermissionRoleDTO : AopObject
    {
        /// <summary>
        /// actorId-否-用户角色对象id，用户表示角色与服务的关联关系-无枚举-被调方提供-无特殊说明
        /// </summary>
        [XmlElement("actor_id")]
        public string ActorId { get; set; }

        /// <summary>
        /// actorName-否-表示用户角色对象名称，暂不消费-无枚举-被调方提供-无特殊说明
        /// </summary>
        [XmlElement("actor_name")]
        public string ActorName { get; set; }

        /// <summary>
        /// permissionRoleCode-否-代表服务角色，根据服务角色判断权限-无枚举-被调方提供-无特殊说明
        /// </summary>
        [XmlElement("permission_role_code")]
        public string PermissionRoleCode { get; set; }

        /// <summary>
        /// permissionRoleName-否-代表服务角色名称-无枚举-被调方提供-无特殊说明
        /// </summary>
        [XmlElement("permission_role_name")]
        public string PermissionRoleName { get; set; }

        /// <summary>
        /// permissionRoleType-否-用于标识服务角色类型-无枚举- 被调方提供-无特殊说明
        /// </summary>
        [XmlElement("permission_role_type")]
        public string PermissionRoleType { get; set; }
    }
}
