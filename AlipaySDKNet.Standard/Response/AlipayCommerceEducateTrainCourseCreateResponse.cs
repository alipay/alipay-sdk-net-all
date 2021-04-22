using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainCourseCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainCourseCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内部课程id
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }
    }
}
