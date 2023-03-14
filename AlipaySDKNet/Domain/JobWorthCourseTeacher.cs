using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JobWorthCourseTeacher Data Structure.
    /// </summary>
    [Serializable]
    public class JobWorthCourseTeacher : AopObject
    {
        /// <summary>
        /// id类型，ID_CARD代表身份证
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 教师id,全局唯一
        /// </summary>
        [XmlElement("teacher_id")]
        public string TeacherId { get; set; }

        /// <summary>
        /// 教师名称
        /// </summary>
        [XmlElement("teacher_name")]
        public string TeacherName { get; set; }
    }
}
