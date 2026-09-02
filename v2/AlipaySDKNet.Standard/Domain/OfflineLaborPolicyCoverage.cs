using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflineLaborPolicyCoverage Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineLaborPolicyCoverage : AopObject
    {
        /// <summary>
        /// 保障责任名称
        /// </summary>
        [XmlElement("coverage_name")]
        public string CoverageName { get; set; }

        /// <summary>
        /// 保障责任编号
        /// </summary>
        [XmlElement("coverage_no")]
        public string CoverageNo { get; set; }

        /// <summary>
        /// 该项生效结束时间
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 该项生效开始时间
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 是否不计免赔
        /// </summary>
        [XmlElement("iop")]
        public long Iop { get; set; }

        /// <summary>
        /// 不计免赔保费，单位：分
        /// </summary>
        [XmlElement("iop_premium")]
        public long IopPremium { get; set; }

        /// <summary>
        /// 该项保费，单位：分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 该项保额，单位：分
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }
    }
}
