using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCourseSyncResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingCourseSyncResponse : AopResponse
    {
        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// DELISTING("下架") AVAILABLE("上架")
        /// </summary>
        [XmlElement("course_status")]
        public string CourseStatus { get; set; }
    }
}
