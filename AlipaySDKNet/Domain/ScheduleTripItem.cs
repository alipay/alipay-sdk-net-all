using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleTripItem Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleTripItem : AopObject
    {
        /// <summary>
        /// 方向，参考方向枚举
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 单程行驶时间(单位min)
        /// </summary>
        [XmlElement("run_time")]
        public long RunTime { get; set; }

        /// <summary>
        /// 若time_span为10，则06:00表示06:00-06:10的时段； 若time_span为30，则06:00表示06:00-06:30的时段
        /// </summary>
        [XmlElement("time_period")]
        public string TimePeriod { get; set; }
    }
}
