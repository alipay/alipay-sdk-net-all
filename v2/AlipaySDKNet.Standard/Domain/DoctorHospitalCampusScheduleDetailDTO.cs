using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorHospitalCampusScheduleDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorHospitalCampusScheduleDetailDTO : AopObject
    {
        /// <summary>
        /// 科室排班信息
        /// </summary>
        [XmlArray("department_schedule_list")]
        [XmlArrayItem("doctor_department_schedule_detail_d_t_o")]
        public List<DoctorDepartmentScheduleDetailDTO> DepartmentScheduleList { get; set; }

        /// <summary>
        /// 距离，单位: m
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 医院id
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 院区简称
        /// </summary>
        [XmlElement("sub_hospital_shore_name")]
        public string SubHospitalShoreName { get; set; }

        /// <summary>
        /// 灵知院区医院编码
        /// </summary>
        [XmlElement("sub_hospital_uniq_code")]
        public string SubHospitalUniqCode { get; set; }
    }
}
