using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserTaskCountingDto Data Structure.
    /// </summary>
    [Serializable]
    public class UserTaskCountingDto : AopObject
    {
        /// <summary>
        /// 周期之内的最大累计计数
        /// </summary>
        [XmlElement("cycle_acc_count")]
        public long CycleAccCount { get; set; }

        /// <summary>
        /// 周期之间的连续计数
        /// </summary>
        [XmlElement("total_consecutive_count")]
        public long TotalConsecutiveCount { get; set; }
    }
}
