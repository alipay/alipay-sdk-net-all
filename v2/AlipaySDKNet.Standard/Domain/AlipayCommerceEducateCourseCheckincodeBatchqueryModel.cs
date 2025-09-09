using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCourseCheckincodeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCourseCheckincodeBatchqueryModel : AopObject
    {
        /// <summary>
        /// 课程签到规则ID
        /// </summary>
        [XmlElement("course_rule_id")]
        public string CourseRuleId { get; set; }

        /// <summary>
        /// 课程签到规则名称
        /// </summary>
        [XmlElement("course_rule_name")]
        public string CourseRuleName { get; set; }

        /// <summary>
        /// 启用状态
        /// </summary>
        [XmlElement("enable_status")]
        public bool EnableStatus { get; set; }

        /// <summary>
        /// 机构内标，取值为学校内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 花名册ID
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }
    }
}
