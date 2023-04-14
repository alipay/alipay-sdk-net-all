using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcpCalcFormula Data Structure.
    /// </summary>
    [Serializable]
    public class VcpCalcFormula : AopObject
    {
        /// <summary>
        /// 优惠基础个数
        /// </summary>
        [XmlElement("base_count")]
        public long BaseCount { get; set; }

        /// <summary>
        /// 封顶次数
        /// </summary>
        [XmlElement("max_count")]
        public long MaxCount { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("reduction_amount")]
        public string ReductionAmount { get; set; }

        /// <summary>
        /// 优惠比率
        /// </summary>
        [XmlElement("reduction_ratio")]
        public string ReductionRatio { get; set; }

        /// <summary>
        /// 随机立减优惠计算，每一条规则 包含最小优惠，最大优惠，这条规则的设置占比（所有占比相加为100%）
        /// </summary>
        [XmlArray("rnd_benefit_rules")]
        [XmlArrayItem("rnd_benefit_rule")]
        public List<RndBenefitRule> RndBenefitRules { get; set; }

        /// <summary>
        /// 取整模式
        /// </summary>
        [XmlElement("rounding_mode")]
        public string RoundingMode { get; set; }

        /// <summary>
        /// 指定金额
        /// </summary>
        [XmlElement("specified_amount")]
        public string SpecifiedAmount { get; set; }
    }
}
