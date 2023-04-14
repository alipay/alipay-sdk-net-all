using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeDepartmentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeDepartmentDTO : AopObject
    {
        /// <summary>
        /// 部门id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }
    }
}
