using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCoursecyclicalCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingCoursecyclicalCreateModel : AopObject
    {
        /// <summary>
        /// 课程ID
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 结课日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 上课时间描述
        /// </summary>
        [XmlElement("schedule_description")]
        public string ScheduleDescription { get; set; }

        /// <summary>
        /// 开班日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
