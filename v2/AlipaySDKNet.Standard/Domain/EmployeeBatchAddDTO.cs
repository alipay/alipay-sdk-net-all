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
        /// 员工所属核算主体，核算主体可用于管控不同员工的出资方式，建议和不同出资账户关联
        /// </summary>
        [XmlArray("accounting_entity_ids")]
        [XmlArrayItem("string")]
        public List<string> AccountingEntityIds { get; set; }

        /// <summary>
        /// 员工所属部门
        /// </summary>
        [XmlArray("department_ids")]
        [XmlArrayItem("string")]
        public List<string> DepartmentIds { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("employee_cert_no")]
        public string EmployeeCertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("employee_cert_type")]
        public string EmployeeCertType { get; set; }

        /// <summary>
        /// 员工邮箱
        /// </summary>
        [XmlElement("employee_email")]
        public string EmployeeEmail { get; set; }

        /// <summary>
        /// 员工手机号
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
        /// 加密证件号（证件号转大写后使用SHA256加密）
        /// </summary>
        [XmlElement("encrypt_cert_no")]
        public string EncryptCertNo { get; set; }

        /// <summary>
        /// 加密手机号（使用SHA256进行加密）
        /// </summary>
        [XmlElement("encrypt_mobile")]
        public string EncryptMobile { get; set; }

        /// <summary>
        /// 员工标签，用于员工的打标分类，后续费控管理可使用标签进行控制，支持输入多个标签，如“差旅员工，用餐员工”等
        /// </summary>
        [XmlArray("label_names")]
        [XmlArrayItem("string")]
        public List<string> LabelNames { get; set; }

        /// <summary>
        /// 个性化信息 <a href='https://opendocs.alipay.com/pre-open/0ceh47?pathHash=14fac87c'>详见文档</a>
        /// </summary>
        [XmlElement("profiles")]
        public string Profiles { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        [XmlArray("role_list")]
        [XmlArrayItem("string")]
        public List<string> RoleList { get; set; }
    }
}
