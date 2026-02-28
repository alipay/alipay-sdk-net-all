using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NSalesSubActivityModify Data Structure.
    /// </summary>
    [Serializable]
    public class NSalesSubActivityModify : AopObject
    {
        /// <summary>
        /// 子任务结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 子任务期号
        /// </summary>
        [XmlElement("period_no")]
        public long PeriodNo { get; set; }

        /// <summary>
        /// 子任务开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 子任务id
        /// </summary>
        [XmlElement("sub_activity_id")]
        public string SubActivityId { get; set; }
    }
}
