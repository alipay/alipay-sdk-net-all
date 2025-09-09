using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorHospitalScheduleInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorHospitalScheduleInfoDTO : AopObject
    {
        /// <summary>
        /// 医院原始名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// main_hos_uniq_code
        /// </summary>
        [XmlElement("main_hos_uniq_code")]
        public string MainHosUniqCode { get; set; }

        /// <summary>
        /// 院区排班列表
        /// </summary>
        [XmlArray("sub_hospital_register_info_list")]
        [XmlArrayItem("doctor_hospital_campus_schedule_detail_d_t_o")]
        public List<DoctorHospitalCampusScheduleDetailDTO> SubHospitalRegisterInfoList { get; set; }
    }
}
