using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCourseInfoSaveResponse.
    /// </summary>
    public class AlipayCommerceEducateCourseInfoSaveResponse : AopResponse
    {
        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }
    }
}
