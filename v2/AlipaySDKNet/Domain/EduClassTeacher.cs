using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduClassTeacher Data Structure.
    /// </summary>
    [Serializable]
    public class EduClassTeacher : AopObject
    {
        /// <summary>
        /// 上课老师Id
        /// </summary>
        [XmlElement("teacher_id")]
        public string TeacherId { get; set; }

        /// <summary>
        /// 上课老师名称
        /// </summary>
        [XmlElement("teacher_name")]
        public string TeacherName { get; set; }
    }
}
