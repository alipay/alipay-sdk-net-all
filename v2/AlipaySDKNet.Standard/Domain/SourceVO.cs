using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SourceVO Data Structure.
    /// </summary>
    [Serializable]
    public class SourceVO : AopObject
    {
        /// <summary>
        /// 每小时一个时间段，按该字段分组筛选号源
        /// </summary>
        [XmlElement("source_group")]
        public string SourceGroup { get; set; }

        /// <summary>
        /// 号源id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 1号
        /// </summary>
        [XmlElement("source_no")]
        public string SourceNo { get; set; }

        /// <summary>
        /// 14:00-14:30
        /// </summary>
        [XmlElement("source_time")]
        public string SourceTime { get; set; }

        /// <summary>
        /// 2024年11月15日
        /// </summary>
        [XmlElement("treat_date")]
        public string TreatDate { get; set; }
    }
}
