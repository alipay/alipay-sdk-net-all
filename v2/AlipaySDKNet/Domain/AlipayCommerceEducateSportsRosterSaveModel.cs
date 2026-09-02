using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSportsRosterSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSportsRosterSaveModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("credential_no")]
        public string CredentialNo { get; set; }

        /// <summary>
        /// 证件类型，仅支持身份证，护照
        /// </summary>
        [XmlElement("credential_type")]
        public string CredentialType { get; set; }

        /// <summary>
        /// 学生所属部门编码
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 学工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 组织角色编码
        /// </summary>
        [XmlElement("org_role_code")]
        public string OrgRoleCode { get; set; }

        /// <summary>
        /// 学校组织code
        /// </summary>
        [XmlElement("organization_code")]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
