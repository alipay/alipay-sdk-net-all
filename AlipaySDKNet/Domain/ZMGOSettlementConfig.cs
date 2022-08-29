using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZMGOSettlementConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ZMGOSettlementConfig : AopObject
    {
        /// <summary>
        /// 会员费扣费名称
        /// </summary>
        [XmlElement("custom_fee_name")]
        public string CustomFeeName { get; set; }

        /// <summary>
        /// 周期灵活扣配置，当商户接入的玩法是周期灵活扣时，此属性为必传
        /// </summary>
        [XmlElement("cycle_flex_withhold_config")]
        public ZMGOCycleFlexConfig CycleFlexWithholdConfig { get; set; }

        /// <summary>
        /// 芝麻GO周期扣配置
        /// </summary>
        [XmlElement("cycle_withhold_config")]
        public ZMGOCycleWithholdConfig CycleWithholdConfig { get; set; }

        /// <summary>
        /// 预计结算延迟天数，当exp_stop_time_mode取值RELATIVE_DATE、ABSOLATE_DATE、ABSOLUTE_PLUS_1_DATE时，必传
        /// </summary>
        [XmlElement("exp_stop_delay_days")]
        public long ExpStopDelayDays { get; set; }

        /// <summary>
        /// 预期结算时间，当exp_stop_time_mode取值APPOINT_DATE时，必传
        /// </summary>
        [XmlElement("exp_stop_time")]
        public string ExpStopTime { get; set; }

        /// <summary>
        /// 预计结算时间模式，取值：（1）RELATIVE_DATE("RELATIVE_DATE", "相对日期"), （2）ABSOLATE_DATE("ABSOLATE_DATE", "绝对日期(当日开始计算)"), （3）ABSOLUTE_PLUS_1_DATE("ABSOLUTE_PLUS_1_DATE", "绝对日期(次日开始计算)"), （4）APPOINT_DATE("APPOINT_DATE", "指定日期")
        /// </summary>
        [XmlElement("exp_stop_time_mode")]
        public string ExpStopTimeMode { get; set; }

        /// <summary>
        /// 按履约次数灵活扣款计划。当settlement_type取值为fulfillTimesCustomSettlement时，此属性必传
        /// </summary>
        [XmlElement("fulfilltimes_custom_settlement_plan")]
        public string FulfilltimesCustomSettlementPlan { get; set; }

        /// <summary>
        /// 结算类型，取值：     BENEFIT_SETTLEMENT("benefitSettlement", "按权益金额结算"),     FULFILL_TIMES_CUSTOM_SETTLEMENT("fulfillTimesCustomSettlement","按履约次数扣款")
        /// </summary>
        [XmlElement("settlement_type")]
        public string SettlementType { get; set; }
    }
}
