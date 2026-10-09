using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HmRecordSummaryItem Data Structure.
    /// </summary>
    [Serializable]
    public class HmRecordSummaryItem : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 记录日期
        /// </summary>
        [XmlElement("record_date")]
        public string RecordDate { get; set; }

        /// <summary>
        /// 打卡次数
        /// </summary>
        [XmlElement("record_num")]
        public long RecordNum { get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        [XmlElement("record_type")]
        public string RecordType { get; set; }
    }
}
