using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCourseInfoSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCourseInfoSaveModel : AopObject
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
        /// 每周天次
        /// </summary>
        [XmlElement("day_of_week")]
        public long DayOfWeek { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 适用组织节点ID列表
        /// </summary>
        [XmlArray("node_id_list")]
        [XmlArrayItem("string")]
        public List<string> NodeIdList { get; set; }

        /// <summary>
        /// 课时节次列表
        /// </summary>
        [XmlArray("period_no_list")]
        [XmlArrayItem("number")]
        public List<long> PeriodNoList { get; set; }

        /// <summary>
        /// 教室外部唯一编号
        /// </summary>
        [XmlElement("place_out_biz_no")]
        public string PlaceOutBizNo { get; set; }

        /// <summary>
        /// 学期ID
        /// </summary>
        [XmlElement("semester_id")]
        public string SemesterId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 课程教师学工号
        /// </summary>
        [XmlElement("teacher_employee_no")]
        public string TeacherEmployeeNo { get; set; }

        /// <summary>
        /// 学期周次列表，即课程在本学期的哪些周上课
        /// </summary>
        [XmlArray("week_list")]
        [XmlArrayItem("number")]
        public List<long> WeekList { get; set; }
    }
}
