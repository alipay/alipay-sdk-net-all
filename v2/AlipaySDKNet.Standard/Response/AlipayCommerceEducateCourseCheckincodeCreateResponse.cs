using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCourseCheckincodeCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateCourseCheckincodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 课程签到规则ID
        /// </summary>
        [XmlElement("course_rule_id")]
        public string CourseRuleId { get; set; }
    }
}
