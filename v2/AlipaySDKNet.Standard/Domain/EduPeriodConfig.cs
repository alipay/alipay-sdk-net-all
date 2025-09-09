using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduPeriodConfig Data Structure.
    /// </summary>
    [Serializable]
    public class EduPeriodConfig : AopObject
    {
        /// <summary>
        /// 课时结束时间，格式"HH:mm"
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 课时节次，表示第几节课
        /// </summary>
        [XmlElement("period_no")]
        public long PeriodNo { get; set; }

        /// <summary>
        /// 课时开始时间，格式"HH:mm"
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
