using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcEmployeeBatchAddFailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcEmployeeBatchAddFailInfo : AopObject
    {
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
        /// 添加失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }
    }
}
