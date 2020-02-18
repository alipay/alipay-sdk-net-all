using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionRoleQueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionRoleQueryResponse : AopResponse
    {
        /// <summary>
        /// 角色拥有信息，无论是否拥有角色，都会返回“角色拥有信息”，如果没有，则返回没有开通。同时需要通过role_code ，查找对应角色的开通情况
        /// </summary>
        [XmlArray("role_infos")]
        [XmlArrayItem("kbadvert_role_info_response")]
        public List<KbadvertRoleInfoResponse> RoleInfos { get; set; }
    }
}
