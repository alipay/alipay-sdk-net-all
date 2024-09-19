using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IncentiveMode Data Structure.
    /// </summary>
    [Serializable]
    public class IncentiveMode : AopObject
    {
        /// <summary>
        /// 完成次数
        /// </summary>
        [XmlElement("finish_num")]
        public long FinishNum { get; set; }

        /// <summary>
        /// 每周获取金币数
        /// </summary>
        [XmlElement("per_incentive_point")]
        public long PerIncentivePoint { get; set; }

        /// <summary>
        /// 每周打卡次数
        /// </summary>
        [XmlElement("per_week_check_times")]
        public long PerWeekCheckTimes { get; set; }

        /// <summary>
        /// 总次数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
