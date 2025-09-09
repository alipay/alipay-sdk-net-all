using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Coverage Data Structure.
    /// </summary>
    [Serializable]
    public class Coverage : AopObject
    {
        /// <summary>
        /// 责任列表
        /// </summary>
        [XmlArray("coverage_liability_list")]
        [XmlArrayItem("coverage_liability")]
        public List<CoverageLiability> CoverageLiabilityList { get; set; }

        /// <summary>
        /// 险种名称
        /// </summary>
        [XmlElement("coverage_name")]
        public string CoverageName { get; set; }

        /// <summary>
        /// 险种编号，险种的唯一标识
        /// </summary>
        [XmlElement("coverage_no")]
        public string CoverageNo { get; set; }

        /// <summary>
        /// 险种终止时间  YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 险种生效时间  YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 是否主险，枚举值
        /// </summary>
        [XmlElement("main_coverage")]
        public string MainCoverage { get; set; }

        /// <summary>
        /// 险种保费 单位：币种标准单位，如：人民币-元（保留2位小数）
        /// </summary>
        [XmlElement("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 险种状态，枚举值
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 险种保额 单位：币种标准单位，如：人民币-元（保留2位小数）
        /// </summary>
        [XmlElement("sum_insured")]
        public string SumInsured { get; set; }
    }
}
