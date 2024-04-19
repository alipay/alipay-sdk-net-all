using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserSubOrganizationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserSubOrganizationDTO : AopObject
    {
        /// <summary>
        /// 成员id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 组织合同列表
        /// </summary>
        [XmlArray("org_contract_list")]
        [XmlArrayItem("organization_contract_d_t_o")]
        public List<OrganizationContractDTO> OrgContractList { get; set; }

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
        /// 角色
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }
    }
}
