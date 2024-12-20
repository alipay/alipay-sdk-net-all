using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CancelRule Data Structure.
    /// </summary>
    [Serializable]
    public class CancelRule : AopObject
    {
        /// <summary>
        /// 当罚金类型penalty_type为固定罚金类型FIXED时，该字段必填。限制同一币种只能传1条固定罚金，当前仅支持CNY。
        /// </summary>
        [XmlArray("penalty_amounts")]
        [XmlArrayItem("penalty_amount")]
        public List<PenaltyAmount> PenaltyAmounts { get; set; }

        /// <summary>
        /// 当罚金类型penalty_type为百分比罚金类型PERCENTAGE时，该字段必填。
        /// </summary>
        [XmlElement("penalty_percent")]
        public PenaltyPercent PenaltyPercent { get; set; }

        /// <summary>
        /// 罚金类型
        /// </summary>
        [XmlElement("penalty_type")]
        public string PenaltyType { get; set; }

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss格式，rule_end_time需晚于rule_start_time，最晚一段规则的rule_end_time需要晚于2099-12-31 00:00:00。  规则生效时间区间遵循[rule_start_time，rule_end_time)，对于同一rateplan节点下的多条规则： 1、规则之间的开始时间和结束时间不允许出现重叠。 例如[1970-01-01 00:00:00，2024-12-10 00:00:00)与[2024-12-09 00:00:00，2099-12-31 00:00:00)这类数据是不被允许的。 2、规则的开始结束时间需要保证连续，例如[1970-01-01 00:00:00，2024-12-10 00:00:00)与[2024-12-10 00:00:00，2099-12-31 00:00:00)为连续的时间区间。
        /// </summary>
        [XmlElement("rule_end_time")]
        public string RuleEndTime { get; set; }

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss格式，rule_end_time需晚于rule_start_time。  规则生效时间区间遵循[rule_start_time，rule_end_time)，对于同一rateplan节点下的多条规则： 1、规则之间的开始时间和结束时间不允许出现重叠。 例如[1970-01-01 00:00:00，2024-12-10 00:00:00)与[2024-12-09 00:00:00，2099-12-31 00:00:00)这类数据是不被允许的。 2、规则的开始结束时间需要保证连续，例如[1970-01-01 00:00:00，2024-12-10 00:00:00)与[2024-12-10 00:00:00，2099-12-31 00:00:00)为连续的时间区间。
        /// </summary>
        [XmlElement("rule_start_time")]
        public string RuleStartTime { get; set; }
    }
}
