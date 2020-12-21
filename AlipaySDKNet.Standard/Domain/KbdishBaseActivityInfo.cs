using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishBaseActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishBaseActivityInfo : AopObject
    {
        /// <summary>
        /// 活动条款链接
        /// </summary>
        [XmlElement("activity_clause_url")]
        public string ActivityClauseUrl { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动说明文案
        /// </summary>
        [XmlElement("activity_remark")]
        public string ActivityRemark { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 活动值
        /// </summary>
        [XmlElement("activity_value")]
        public string ActivityValue { get; set; }
    }
}
