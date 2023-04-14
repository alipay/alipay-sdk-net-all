using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeInfoModifyModel : AopObject
    {
        /// <summary>
        /// 员工所属部门
        /// </summary>
        [XmlArray("department_ids")]
        [XmlArrayItem("string")]
        public List<string> DepartmentIds { get; set; }

        /// <summary>
        /// 员工邮箱
        /// </summary>
        [XmlElement("employee_email")]
        public string EmployeeEmail { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("employee_name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 角色列表，目前只支持填一种角色 USER 普通员工 ADMIN 管理员
        /// </summary>
        [XmlArray("role_list")]
        [XmlArrayItem("string")]
        public List<string> RoleList { get; set; }
    }
}
