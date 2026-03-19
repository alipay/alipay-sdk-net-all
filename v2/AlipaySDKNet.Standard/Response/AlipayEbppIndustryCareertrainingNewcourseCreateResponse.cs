using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingNewcourseCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingNewcourseCreateResponse : AopResponse
    {
        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }
    }
}
