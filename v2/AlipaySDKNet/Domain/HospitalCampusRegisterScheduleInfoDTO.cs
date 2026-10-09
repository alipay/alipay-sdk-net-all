using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HospitalCampusRegisterScheduleInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HospitalCampusRegisterScheduleInfoDTO : AopObject
    {
        /// <summary>
        /// 距离，单位: m，意图中指定医院名称时，该字段有值
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 排班日期列表
        /// </summary>
        [XmlArray("schedule_date_list")]
        [XmlArrayItem("register_schedule_date_d_t_o")]
        public List<RegisterScheduleDateDTO> ScheduleDateList { get; set; }

        /// <summary>
        /// 院区简称，意图中指定医院名称时，该字段有值
        /// </summary>
        [XmlElement("sub_hospital_shore_name")]
        public string SubHospitalShoreName { get; set; }

        /// <summary>
        /// 灵知院区医院编码，意图中指定医院名称时，该字段有值
        /// </summary>
        [XmlElement("sub_hospital_uniq_code")]
        public string SubHospitalUniqCode { get; set; }
    }
}
