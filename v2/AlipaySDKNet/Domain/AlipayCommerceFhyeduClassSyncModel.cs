using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFhyeduClassSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFhyeduClassSyncModel : AopObject
    {
        /// <summary>
        /// 上课地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        [XmlElement("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 上课教室
        /// </summary>
        [XmlElement("class_room_name")]
        public string ClassRoomName { get; set; }

        /// <summary>
        /// 课程id
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 授课课程名称
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 预计消耗课时
        /// </summary>
        [XmlElement("plan_consume_lessions")]
        public string PlanConsumeLessions { get; set; }

        /// <summary>
        /// 课次开始时间
        /// </summary>
        [XmlElement("sched_begin_time")]
        public string SchedBeginTime { get; set; }

        /// <summary>
        /// 上课内容
        /// </summary>
        [XmlElement("sched_content")]
        public string SchedContent { get; set; }

        /// <summary>
        /// 课次结束时间
        /// </summary>
        [XmlElement("sched_end_time")]
        public string SchedEndTime { get; set; }

        /// <summary>
        /// 课次id
        /// </summary>
        [XmlElement("sched_id")]
        public string SchedId { get; set; }

        /// <summary>
        /// 学员id
        /// </summary>
        [XmlElement("student_id")]
        public string StudentId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("teacher_list")]
        [XmlArrayItem("edu_class_teacher")]
        public List<EduClassTeacher> TeacherList { get; set; }
    }
}
