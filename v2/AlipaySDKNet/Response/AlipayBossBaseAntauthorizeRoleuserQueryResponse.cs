using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseAntauthorizeRoleuserQueryResponse.
    /// </summary>
    public class AlipayBossBaseAntauthorizeRoleuserQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询queryUserlist返回结果封装
        /// </summary>
        [XmlArray("role_user_list")]
        [XmlArrayItem("org_role_d_t_o")]
        public List<OrgRoleDTO> RoleUserList { get; set; }
    }
}
