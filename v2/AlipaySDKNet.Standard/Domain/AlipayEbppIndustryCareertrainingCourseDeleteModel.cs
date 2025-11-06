using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCourseDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingCourseDeleteModel : AopObject
    {
        /// <summary>
        /// 课程id，与out_course_id至少传一个
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 外部课程id，与course_id至少传一个
        /// </summary>
        [XmlElement("out_course_id")]
        public string OutCourseId { get; set; }
    }
}
