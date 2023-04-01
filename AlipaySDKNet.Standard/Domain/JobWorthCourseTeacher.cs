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
        /// 教师描述信息，由商户自行设置，配置的文案将会在课程详情页透出
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

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
