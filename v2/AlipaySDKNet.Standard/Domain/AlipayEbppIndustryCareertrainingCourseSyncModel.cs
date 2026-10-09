using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingCourseSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingCourseSyncModel : AopObject
    {
        /// <summary>
        /// 课程ID, 以此作为主键更新
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 枚举:  DELISTING("下架") AVAILABLE("上架")
        /// </summary>
        [XmlElement("course_status")]
        public string CourseStatus { get; set; }
    }
}
