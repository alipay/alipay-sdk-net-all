using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorWorkDepartmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorWorkDepartmentInfo : AopObject
    {
        /// <summary>
        /// 科室id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }
    }
}
