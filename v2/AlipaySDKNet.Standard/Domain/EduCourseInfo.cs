using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduCourseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduCourseInfo : AopObject
    {
        /// <summary>
        /// 课程描述
        /// </summary>
        [XmlElement("course_desc")]
        public string CourseDesc { get; set; }

        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 每周天次，用1-7分别表示周一到周日
        /// </summary>
        [XmlElement("day_of_week")]
        public long DayOfWeek { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 课程适用组织节点列表。
        /// </summary>
        [XmlArray("node_list")]
        [XmlArrayItem("edu_node_info")]
        public List<EduNodeInfo> NodeList { get; set; }

        /// <summary>
        /// 课时信息
        /// </summary>
        [XmlElement("period_info")]
        public EduPeriodInfo PeriodInfo { get; set; }

        /// <summary>
        /// 课时节次，即每天第几节课，与课时配置保持一致
        /// </summary>
        [XmlArray("period_no_list")]
        [XmlArrayItem("number")]
        public List<long> PeriodNoList { get; set; }

        /// <summary>
        /// 教室位置ID
        /// </summary>
        [XmlElement("place_id")]
        public string PlaceId { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [XmlElement("place_name")]
        public string PlaceName { get; set; }

        /// <summary>
        /// 学期ID
        /// </summary>
        [XmlElement("semester_id")]
        public string SemesterId { get; set; }

        /// <summary>
        /// 学期名称
        /// </summary>
        [XmlElement("semester_name")]
        public string SemesterName { get; set; }

        /// <summary>
        /// 教师花名册ID
        /// </summary>
        [XmlElement("teacher_roster_id")]
        public string TeacherRosterId { get; set; }

        /// <summary>
        /// 教师名称
        /// </summary>
        [XmlElement("teacher_roster_name")]
        public string TeacherRosterName { get; set; }

        /// <summary>
        /// 学期周次列表，即课程在本学期的哪些周上课
        /// </summary>
        [XmlArray("week_list")]
        [XmlArrayItem("number")]
        public List<long> WeekList { get; set; }
    }
}
