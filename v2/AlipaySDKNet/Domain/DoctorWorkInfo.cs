using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorWorkInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorWorkInfo : AopObject
    {
        /// <summary>
        /// 科室工作信息
        /// </summary>
        [XmlArray("department_info")]
        [XmlArrayItem("doctor_work_department_info")]
        public List<DoctorWorkDepartmentInfo> DepartmentInfo { get; set; }

        /// <summary>
        /// 医院id
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }
    }
}
