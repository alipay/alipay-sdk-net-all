using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UseDuration Data Structure.
    /// </summary>
    [Serializable]
    public class UseDuration : AopObject
    {
        /// <summary>
        /// 金额卡的不可用时间范围
        /// </summary>
        [XmlArray("can_no_use_date_list")]
        [XmlArrayItem("can_no_use_limit_day_info")]
        public List<CanNoUseLimitDayInfo> CanNoUseDateList { get; set; }

        /// <summary>
        /// 金额卡的可用时间范围
        /// </summary>
        [XmlArray("can_use_date_list")]
        [XmlArrayItem("limit_day_info")]
        public List<LimitDayInfo> CanUseDateList { get; set; }

        /// <summary>
        /// 使用时段类型（任意时间可用、指定时段可用）
        /// </summary>
        [XmlElement("use_time_type")]
        public string UseTimeType { get; set; }
    }
}
