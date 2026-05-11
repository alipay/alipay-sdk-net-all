using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargerDiscountActivityQuota Data Structure.
    /// </summary>
    [Serializable]
    public class ChargerDiscountActivityQuota : AopObject
    {
        /// <summary>
        /// 周期类型
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 用户在周期内剩余可参加活动的次数
        /// </summary>
        [XmlElement("remaining_count")]
        public long RemainingCount { get; set; }

        /// <summary>
        /// 用户在周期内可参加活动的总次数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 用户在周期内已参数活动的次数
        /// </summary>
        [XmlElement("used_count")]
        public long UsedCount { get; set; }
    }
}
