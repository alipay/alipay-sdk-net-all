using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExecutionPlan Data Structure.
    /// </summary>
    [Serializable]
    public class ExecutionPlan : AopObject
    {
        /// <summary>
        /// 周期扣预期执行时间，格式为YYYY-MM-DD
        /// </summary>
        [XmlElement("execute_time")]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 周期扣执行计划最晚执行时间，格式为YYYY-MM-DD
        /// </summary>
        [XmlElement("latest_execute_time")]
        public string LatestExecuteTime { get; set; }

        /// <summary>
        /// 该值为自然数，表示周期扣期数。
        /// </summary>
        [XmlElement("period_id")]
        public string PeriodId { get; set; }

        /// <summary>
        /// 周期扣中单笔金额，单位是元
        /// </summary>
        [XmlElement("single_amount")]
        public string SingleAmount { get; set; }
    }
}
