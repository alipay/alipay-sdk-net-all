using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LoginUserDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LoginUserDTO : AopObject
    {
        /// <summary>
        /// ipRoleId-否-操作员唯一标识-无枚举-被调方返回值-无特殊说明
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// LabelDTO 不唯一 作为map拓展字段 无枚举 调用方提供 无特殊说明
        /// </summary>
        [XmlElement("tenant_ext_info")]
        public LabelDTO TenantExtInfo { get; set; }

        /// <summary>
        /// tenantId-否-租户唯一标识-无枚举-被调方返回值-无特殊说明
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// tenantName-否-租户名称-无枚举-被调方返回值-无特殊说明
        /// </summary>
        [XmlElement("tenant_name")]
        public string TenantName { get; set; }

        /// <summary>
        /// tenant_status 不唯一 表示租户状态 无枚举 被调方提供 无特殊说明
        /// </summary>
        [XmlElement("tenant_status")]
        public string TenantStatus { get; set; }
    }
}
