using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiUserInfo : AopObject
    {
        /// <summary>
        /// 旧平台用户id
        /// </summary>
        [XmlElement("clv_user_id")]
        public string ClvUserId { get; set; }

        /// <summary>
        /// 用工类型code
        /// </summary>
        [XmlElement("employee_code")]
        public string EmployeeCode { get; set; }

        /// <summary>
        /// 花名
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 用户组织信息
        /// </summary>
        [XmlArray("org_nodes")]
        [XmlArrayItem("open_api_organization_node_info")]
        public List<OpenApiOrganizationNodeInfo> OrgNodes { get; set; }

        /// <summary>
        /// 用户风险等级
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 用户角色信息
        /// </summary>
        [XmlArray("roles")]
        [XmlArrayItem("open_api_role_info")]
        public List<OpenApiRoleInfo> Roles { get; set; }

        /// <summary>
        /// 用户技能组信息
        /// </summary>
        [XmlArray("skill_groups")]
        [XmlArrayItem("open_api_skill_group_info")]
        public List<OpenApiSkillGroupInfo> SkillGroups { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_tnst_id")]
        public string TntTnstId { get; set; }

        /// <summary>
        /// 星云用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户资源信息
        /// </summary>
        [XmlElement("user_resource_info")]
        public OpenApiUserResourceInfo UserResourceInfo { get; set; }

        /// <summary>
        /// 工作状态
        /// </summary>
        [XmlElement("work_status")]
        public string WorkStatus { get; set; }
    }
}
