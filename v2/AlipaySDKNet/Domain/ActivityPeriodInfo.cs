using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityPeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityPeriodInfo : AopObject
    {
        /// <summary>
        /// 活动唯一编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 当期活动结束时间
        /// </summary>
        [XmlElement("round_end_time")]
        public string RoundEndTime { get; set; }

        /// <summary>
        /// 活动期次ID
        /// </summary>
        [XmlElement("round_id")]
        public string RoundId { get; set; }

        /// <summary>
        /// 期次名称
        /// </summary>
        [XmlElement("round_name")]
        public string RoundName { get; set; }

        /// <summary>
        /// 当期活动开始时间
        /// </summary>
        [XmlElement("round_start_time")]
        public string RoundStartTime { get; set; }

        /// <summary>
        /// 报名截止时间
        /// </summary>
        [XmlElement("sign_up_end_time")]
        public string SignUpEndTime { get; set; }

        /// <summary>
        /// 报名开始时间
        /// </summary>
        [XmlElement("sign_up_start_time")]
        public string SignUpStartTime { get; set; }
    }
}
