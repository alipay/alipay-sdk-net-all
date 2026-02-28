using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCoursePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingCoursePublishModel : AopObject
    {
        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 投放状态 LAUNCH 投放 CANCEL_LAUNCH 撤退投放（仅当前商品为非审核中可撤销）
        /// </summary>
        [XmlElement("publish_status")]
        public string PublishStatus { get; set; }
    }
}
