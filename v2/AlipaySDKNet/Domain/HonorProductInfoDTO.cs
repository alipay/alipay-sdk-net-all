using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorProductInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorProductInfoDTO : AopObject
    {
        /// <summary>
        /// 年利率, 示例: 23.4 【即23.4%】
        /// </summary>
        [XmlElement("apr")]
        public string Apr { get; set; }

        /// <summary>
        /// 日利率, 示例: 0.065 【即0.065%】
        /// </summary>
        [XmlElement("day_rate")]
        public string DayRate { get; set; }

        /// <summary>
        /// 是否可提前还款(默认true)
        /// </summary>
        [XmlElement("early_repay")]
        public bool EarlyRepay { get; set; }

        /// <summary>
        /// 还款方式，枚举值：1-等额本息(灵活还)，2-等额本金(灵活还)，3-先息后本(灵活还)，4-等额本息(按期还)
        /// </summary>
        [XmlElement("repay_method")]
        public long RepayMethod { get; set; }

        /// <summary>
        /// 临价年利率,示例:23.4 【即23.4%】,临价时需返回
        /// </summary>
        [XmlElement("temp_apr")]
        public string TempApr { get; set; }

        /// <summary>
        /// 临价日利率, 示例: 0.065 【即0.065%】, 临价时需返回
        /// </summary>
        [XmlElement("temp_day_rate")]
        public string TempDayRate { get; set; }

        /// <summary>
        /// 临价截止时间, 示例: 2020-07-0222:22:00, 临价时需返回
        /// </summary>
        [XmlElement("temp_price_due_time")]
        public string TempPriceDueTime { get; set; }

        /// <summary>
        /// 期数列表
        /// </summary>
        [XmlArray("term_nums")]
        [XmlArrayItem("number")]
        public List<long> TermNums { get; set; }
    }
}
