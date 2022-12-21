using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnitedCountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UnitedCountInfo : AopObject
    {
        /// <summary>
        /// 日上限
        /// </summary>
        [XmlElement("max_day_count")]
        public long MaxDayCount { get; set; }

        /// <summary>
        /// 终生上限(-1代表不限制)
        /// </summary>
        [XmlElement("max_life_count")]
        public long MaxLifeCount { get; set; }

        /// <summary>
        /// 月上限
        /// </summary>
        [XmlElement("max_month_count")]
        public long MaxMonthCount { get; set; }

        /// <summary>
        /// 周上限
        /// </summary>
        [XmlElement("max_week_count")]
        public long MaxWeekCount { get; set; }

        /// <summary>
        /// 日剩余
        /// </summary>
        [XmlElement("remain_day_count")]
        public long RemainDayCount { get; set; }

        /// <summary>
        /// 终生剩余
        /// </summary>
        [XmlElement("remain_life_count")]
        public long RemainLifeCount { get; set; }

        /// <summary>
        /// 月剩余
        /// </summary>
        [XmlElement("remain_month_count")]
        public long RemainMonthCount { get; set; }

        /// <summary>
        /// 周剩余
        /// </summary>
        [XmlElement("remain_week_count")]
        public long RemainWeekCount { get; set; }
    }
}
