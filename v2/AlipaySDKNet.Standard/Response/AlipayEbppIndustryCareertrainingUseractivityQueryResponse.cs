using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingUseractivityQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingUseractivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动结束时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("activity_end_time")]
        public string ActivityEndTime { get; set; }

        /// <summary>
        /// 活动开始时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("activity_status")]
        public bool ActivityStatus { get; set; }

        /// <summary>
        /// 是否可以参与
        /// </summary>
        [XmlElement("can_join")]
        public bool CanJoin { get; set; }
    }
}
