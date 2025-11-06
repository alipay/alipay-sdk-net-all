using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserOrgEntityInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserOrgEntityInfoDTO : AopObject
    {
        /// <summary>
        /// 是否企业组织
        /// </summary>
        [XmlElement("company_flag")]
        public bool CompanyFlag { get; set; }

        /// <summary>
        /// 企业实体名称
        /// </summary>
        [XmlElement("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 是否退出组织
        /// </summary>
        [XmlElement("exit_org_flag")]
        public bool ExitOrgFlag { get; set; }

        /// <summary>
        /// 退出组织时间
        /// </summary>
        [XmlElement("exit_org_time")]
        public string ExitOrgTime { get; set; }

        /// <summary>
        /// 加入组织时间
        /// </summary>
        [XmlElement("join_org_time")]
        public string JoinOrgTime { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 根组织ID
        /// </summary>
        [XmlElement("root_id")]
        public string RootId { get; set; }
    }
}
