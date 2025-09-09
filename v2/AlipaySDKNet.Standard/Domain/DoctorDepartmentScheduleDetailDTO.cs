using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorDepartmentScheduleDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorDepartmentScheduleDetailDTO : AopObject
    {
        /// <summary>
        /// 科室Id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 排班信息
        /// </summary>
        [XmlArray("schedule_date_list")]
        [XmlArrayItem("doctor_register_schedule_date_d_t_o")]
        public List<DoctorRegisterScheduleDateDTO> ScheduleDateList { get; set; }
    }
}
