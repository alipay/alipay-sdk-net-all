using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeBatchAddDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeBatchAddDTO : AopObject
    {
        /// <summary>
        /// 员工所属部门
        /// </summary>
        [XmlArray("department_ids")]
        [XmlArrayItem("string")]
        public List<string> DepartmentIds { get; set; }

        /// <summary>
        /// 证件号，需搭配证件类型使用。与加密证件号不可同时传入
        /// </summary>
        [XmlElement("employee_cert_no")]
        public string EmployeeCertNo { get; set; }

        /// <summary>
        /// 证件类型，搭配证件号使用
        /// </summary>
        [XmlElement("employee_cert_type")]
        public string EmployeeCertType { get; set; }

        /// <summary>
        /// 员工邮箱，和手机号二选一
        /// </summary>
        [XmlElement("employee_email")]
        public string EmployeeEmail { get; set; }

        /// <summary>
        /// 员工手机号，和邮箱二选一
        /// </summary>
        [XmlElement("employee_mobile")]
        public string EmployeeMobile { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("employee_name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工编号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 加密证件号（证件号转大写后使用SHA256加密），需搭配证件类型使用。与非加密证件号不可同时存在
        /// </summary>
        [XmlElement("encrypt_cert_no")]
        public string EncryptCertNo { get; set; }

        /// <summary>
        /// 加密手机号（使用SHA256进行加密），不可与手机号同时存在
        /// </summary>
        [XmlElement("encrypt_mobile")]
        public string EncryptMobile { get; set; }

        /// <summary>
        /// 角色列表，目前只支持填一种角色，默认为USER
        /// </summary>
        [XmlArray("role_list")]
        [XmlArrayItem("string")]
        public List<string> RoleList { get; set; }
    }
}
