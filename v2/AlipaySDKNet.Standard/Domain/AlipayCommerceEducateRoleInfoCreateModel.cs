using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateRoleInfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateRoleInfoCreateModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        [XmlElement("role_desc")]
        public string RoleDesc { get; set; }

        /// <summary>
        /// 角色图片URL
        /// </summary>
        [XmlElement("role_logo")]
        public string RoleLogo { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [XmlElement("role_name")]
        public string RoleName { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }
    }
}
