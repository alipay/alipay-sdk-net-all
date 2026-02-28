using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SportsRunRecord Data Structure.
    /// </summary>
    [Serializable]
    public class SportsRunRecord : AopObject
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 学生学号或教师职工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 跑步结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 跑步记录达标标识
        /// </summary>
        [XmlElement("is_valid")]
        public long IsValid { get; set; }

        /// <summary>
        /// 跑步记录状态中文描述
        /// </summary>
        [XmlElement("is_valid_name")]
        public string IsValidName { get; set; }

        /// <summary>
        /// 跑步记录未达标原因
        /// </summary>
        [XmlElement("mark")]
        public string Mark { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 跑步记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 本次跑步距离，单位公里
        /// </summary>
        [XmlElement("run_distance")]
        public string RunDistance { get; set; }

        /// <summary>
        /// 本次跑步持续时长，单位分钟
        /// </summary>
        [XmlElement("run_duration")]
        public string RunDuration { get; set; }

        /// <summary>
        /// 本次跑步平均配速，单位分钟/公里
        /// </summary>
        [XmlElement("run_speed")]
        public string RunSpeed { get; set; }

        /// <summary>
        /// 跑步开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 本次跑步平均步频，单位步数/分钟
        /// </summary>
        [XmlElement("step_frequency")]
        public string StepFrequency { get; set; }
    }
}
