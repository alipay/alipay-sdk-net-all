using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZMGOCycleWithholdConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ZMGOCycleWithholdConfig : AopObject
    {
        /// <summary>
        /// 扣款计划
        /// </summary>
        [XmlArray("deduct_plan")]
        [XmlArrayItem("string")]
        public List<string> DeductPlan { get; set; }

        /// <summary>
        /// 豁免期天数
        /// </summary>
        [XmlElement("exemption_period")]
        public string ExemptionPeriod { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 扣款周期类型，支持DAY-天模式，MONTH-月模式
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 是否支持周期扣高级模式，高级模式下扣款计划中内一起的扣款金额可以进行定制
        /// </summary>
        [XmlElement("support_cycle_withhold_high_mode")]
        public bool SupportCycleWithholdHighMode { get; set; }

        /// <summary>
        /// 是否支持豁免期，如果支持豁免期，用户开通后再豁免期内退出无需扣款
        /// </summary>
        [XmlElement("support_exemption_period")]
        public bool SupportExemptionPeriod { get; set; }

        /// <summary>
        /// 设置扣款模式，目前支持每月固定日期或固定时间间隔
        /// </summary>
        [XmlElement("withhold_mode")]
        public string WithholdMode { get; set; }
    }
}
