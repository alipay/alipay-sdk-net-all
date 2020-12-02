using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainActivitystatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTrainActivitystatusModifyModel : AopObject
    {
        /// <summary>
        /// 活动 id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 领取状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 课程id
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 加密后的手机号
        /// </summary>
        [XmlElement("encode_mobile")]
        public string EncodeMobile { get; set; }

        /// <summary>
        /// 错误描述 (SPECIAL_MOBILE_NUMBER)
        /// </summary>
        [XmlElement("fail_desc")]
        public string FailDesc { get; set; }
    }
}
