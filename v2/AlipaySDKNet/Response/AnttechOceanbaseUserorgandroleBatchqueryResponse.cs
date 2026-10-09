using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseUserorgandroleBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbaseUserorgandroleBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用户组织角色列表
        /// </summary>
        [XmlArray("user_org_and_role_list")]
        [XmlArrayItem("user_org_and_role_d_t_o")]
        public List<UserOrgAndRoleDTO> UserOrgAndRoleList { get; set; }
    }
}
