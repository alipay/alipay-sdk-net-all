using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionRecurring Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionRecurring : AopObject
    {
        /// <summary>
        /// 计价周期单位，仅支持 DAY 或 MONTH，大小写不敏感；年付使用 MONTH + interval_count=12 表达
        /// </summary>
        [XmlElement("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// 计价周期间隔，必须为正整数；当 interval=DAY 时不得小于 7
        /// </summary>
        [XmlElement("interval_count")]
        public long IntervalCount { get; set; }
    }
}
