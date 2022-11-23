using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CollectLimitRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CollectLimitRuleDTO : AopObject
    {
        /// <summary>
        /// 1  就是一次
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// DAY ： 天;WEEK ：周;MONTH ： 月;YEAR ： 年;LIFE_TIME ： 终生
        /// </summary>
        [XmlElement("limit_time_type")]
        public string LimitTimeType { get; set; }
    }
}
