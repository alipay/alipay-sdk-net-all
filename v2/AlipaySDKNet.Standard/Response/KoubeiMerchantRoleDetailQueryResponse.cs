using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantRoleDetailQueryResponse.
    /// </summary>
    public class KoubeiMerchantRoleDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 根据主体查询到的主体拥有的角色信息
        /// </summary>
        [XmlArray("permissions")]
        [XmlArrayItem("business_permission")]
        public List<BusinessPermission> Permissions { get; set; }

        /// <summary>
        /// 角色码
        /// </summary>
        [XmlElement("role_code")]
        public string RoleCode { get; set; }

        /// <summary>
        /// 人员管理场景角色id
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 人员管理场景角色名称
        /// </summary>
        [XmlElement("role_name")]
        public string RoleName { get; set; }
    }
}
