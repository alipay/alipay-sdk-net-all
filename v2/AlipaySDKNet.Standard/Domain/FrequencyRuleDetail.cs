using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FrequencyRuleDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FrequencyRuleDetail : AopObject
    {
        /// <summary>
        /// 频次单位数量，2月1次，则frequencyDuration为2，totalTimes为1，frequencyType为MONTH
        /// </summary>
        [XmlElement("frequency_duration")]
        public string FrequencyDuration { get; set; }

        /// <summary>
        /// 频次类型：DAY-自然日频次，MONTH-自然月频次，INFINITE-永久频次
        /// </summary>
        [XmlElement("frequency_type")]
        public string FrequencyType { get; set; }

        /// <summary>
        /// 总次数
        /// </summary>
        [XmlElement("total_times")]
        public long TotalTimes { get; set; }

        /// <summary>
        /// 已使用次数
        /// </summary>
        [XmlElement("used_times")]
        public long UsedTimes { get; set; }
    }
}
