using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCourseCheckinqrcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCourseCheckinqrcodeQueryModel : AopObject
    {
        /// <summary>
        /// 课程签到规则ID
        /// </summary>
        [XmlElement("course_rule_id")]
        public string CourseRuleId { get; set; }

        /// <summary>
        /// 机构内标，取值来自学校内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 花名册ID
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }
    }
}
