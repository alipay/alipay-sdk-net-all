using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserOrganizationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserOrganizationDTO : AopObject
    {
        /// <summary>
        /// 实体id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 成员id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 维保校验状态
        /// </summary>
        [XmlElement("ma_check_status")]
        public long MaCheckStatus { get; set; }

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

        /// <summary>
        /// 子组织列表
        /// </summary>
        [XmlArray("user_sub_org_list")]
        [XmlArrayItem("user_sub_organization_d_t_o")]
        public List<UserSubOrganizationDTO> UserSubOrgList { get; set; }

        /// <summary>
        /// 工单权限
        /// </summary>
        [XmlElement("work_order_permission")]
        public bool WorkOrderPermission { get; set; }
    }
}
