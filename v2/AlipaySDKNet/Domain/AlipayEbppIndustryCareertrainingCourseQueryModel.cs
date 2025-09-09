using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCourseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingCourseQueryModel : AopObject
    {
        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 是否查询编辑版本，false查询在线版本，true查询编辑版本。默认为false
        /// </summary>
        [XmlElement("need_edit_version")]
        public bool NeedEditVersion { get; set; }

        /// <summary>
        /// 外部课程ID
        /// </summary>
        [XmlElement("out_course_id")]
        public string OutCourseId { get; set; }
    }
}
