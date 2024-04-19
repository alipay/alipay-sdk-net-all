using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishTimeRangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishTimeRangeInfo : AopObject
    {
        /// <summary>
        /// 结束时间点
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 起始时间点
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
