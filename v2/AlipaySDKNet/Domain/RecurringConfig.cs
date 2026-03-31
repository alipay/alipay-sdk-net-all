using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecurringConfig Data Structure.
    /// </summary>
    [Serializable]
    public class RecurringConfig : AopObject
    {
        /// <summary>
        /// 计价周期单位，和interval_count组合使用
        /// </summary>
        [XmlElement("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// 计价周期间隔，和interval组合使用
        /// </summary>
        [XmlElement("interval_count")]
        public long IntervalCount { get; set; }
    }
}
