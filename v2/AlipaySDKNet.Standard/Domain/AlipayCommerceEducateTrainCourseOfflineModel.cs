using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainCourseOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTrainCourseOfflineModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝内部课程id
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }
    }
}
