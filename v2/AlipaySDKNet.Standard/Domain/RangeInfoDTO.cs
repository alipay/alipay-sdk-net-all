using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RangeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RangeInfoDTO : AopObject
    {
        /// <summary>
        /// 是否可约
        /// </summary>
        [XmlElement("available")]
        public bool Available { get; set; }

        /// <summary>
        /// 日期类型
        /// </summary>
        [XmlElement("date_type")]
        public long DateType { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否立即预约
        /// </summary>
        [XmlElement("immediately")]
        public bool Immediately { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
