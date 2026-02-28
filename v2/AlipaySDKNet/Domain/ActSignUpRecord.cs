using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActSignUpRecord Data Structure.
    /// </summary>
    [Serializable]
    public class ActSignUpRecord : AopObject
    {
        /// <summary>
        /// 活动唯一编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("activity_round_end_time")]
        public string ActivityRoundEndTime { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("activity_round_start_time")]
        public string ActivityRoundStartTime { get; set; }

        /// <summary>
        /// 用户活动结束时间
        /// </summary>
        [XmlElement("activity_user_end_time")]
        public string ActivityUserEndTime { get; set; }

        /// <summary>
        /// 用户活动开始时间
        /// </summary>
        [XmlElement("activity_user_start_time")]
        public string ActivityUserStartTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 报名记录唯一ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 活动期次ID
        /// </summary>
        [XmlElement("round_id")]
        public string RoundId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 主体ID
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 报名主体类型
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
