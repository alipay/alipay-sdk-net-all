using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SportsWhiteItem Data Structure.
    /// </summary>
    [Serializable]
    public class SportsWhiteItem : AopObject
    {
        /// <summary>
        /// 绑定状态 BIND 已绑定 / UNBIND 未绑定
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("credential_no")]
        public string CredentialNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("credential_type")]
        public string CredentialType { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 部门编码
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 学工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 花名册性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 花名册姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 身份编码
        /// </summary>
        [XmlElement("org_role_code")]
        public string OrgRoleCode { get; set; }

        /// <summary>
        /// 身份名称
        /// </summary>
        [XmlElement("org_role_name")]
        public string OrgRoleName { get; set; }

        /// <summary>
        /// 学校组织code
        /// </summary>
        [XmlElement("organization_code")]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 花名册编码
        /// </summary>
        [XmlElement("roster_code")]
        public string RosterCode { get; set; }

        /// <summary>
        /// 白名单主键编码
        /// </summary>
        [XmlElement("white_code")]
        public string WhiteCode { get; set; }

        /// <summary>
        /// 白名单类型
        /// </summary>
        [XmlElement("white_type")]
        public string WhiteType { get; set; }

        /// <summary>
        /// 白名单类型名称
        /// </summary>
        [XmlElement("white_type_name")]
        public string WhiteTypeName { get; set; }
    }
}
