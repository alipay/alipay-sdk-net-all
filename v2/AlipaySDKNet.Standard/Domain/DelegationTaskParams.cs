using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DelegationTaskParams Data Structure.
    /// </summary>
    [Serializable]
    public class DelegationTaskParams : AopObject
    {
        /// <summary>
        /// 如15天周期内可执行3次，这里是15次，周期单元前的数据
        /// </summary>
        [XmlElement("period_count")]
        public string PeriodCount { get; set; }

        /// <summary>
        /// 单周期次数（如15天周期内可执行3次，这里是3，一个周期单元可执行的次数）
        /// </summary>
        [XmlElement("period_times")]
        public string PeriodTimes { get; set; }

        /// <summary>
        /// 周期单元（枚举：DAY-日、WEEK-周、MONTH-月、QUARTER-季、HALF_YEAR-半年、YEAR-年）
        /// </summary>
        [XmlElement("period_unit")]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// 总周期数
        /// </summary>
        [XmlElement("total_periods")]
        public string TotalPeriods { get; set; }
    }
}
