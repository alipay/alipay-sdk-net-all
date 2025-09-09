using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FilterItem Data Structure.
    /// </summary>
    [Serializable]
    public class FilterItem : AopObject
    {
        /// <summary>
        /// 平台科室id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 排班日期，格式: MM-dd
        /// </summary>
        [XmlElement("schedule_date")]
        public string ScheduleDate { get; set; }

        /// <summary>
        /// 灵知院区医院id
        /// </summary>
        [XmlElement("sub_hospital_uniq_code")]
        public string SubHospitalUniqCode { get; set; }
    }
}
