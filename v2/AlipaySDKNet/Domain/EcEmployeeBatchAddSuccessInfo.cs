using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcEmployeeBatchAddSuccessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcEmployeeBatchAddSuccessInfo : AopObject
    {
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
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

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
        /// 加密证件号
        /// </summary>
        [XmlElement("encrypt_cert_no")]
        public string EncryptCertNo { get; set; }

        /// <summary>
        /// 加密手机号
        /// </summary>
        [XmlElement("encrypt_mobile")]
        public string EncryptMobile { get; set; }
    }
}
