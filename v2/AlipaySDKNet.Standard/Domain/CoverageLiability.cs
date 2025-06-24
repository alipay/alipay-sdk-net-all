using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CoverageLiability Data Structure.
    /// </summary>
    [Serializable]
    public class CoverageLiability : AopObject
    {
        /// <summary>
        /// 赔付次数
        /// </summary>
        [XmlElement("compensation_times")]
        public long CompensationTimes { get; set; }

        /// <summary>
        /// 免赔额 单位：币种标准单位，如：人民币-元（保留2位小数）
        /// </summary>
        [XmlElement("deductible")]
        public string Deductible { get; set; }

        /// <summary>
        /// 责任描述
        /// </summary>
        [XmlElement("liability_desc")]
        public string LiabilityDesc { get; set; }

        /// <summary>
        /// 责任名称
        /// </summary>
        [XmlElement("liability_name")]
        public string LiabilityName { get; set; }

        /// <summary>
        /// 责任的唯一标识
        /// </summary>
        [XmlElement("liability_no")]
        public string LiabilityNo { get; set; }

        /// <summary>
        /// 责任保额 单位：币种标准单位，如：人民币-元（保留2位小数）
        /// </summary>
        [XmlElement("sum_insured")]
        public string SumInsured { get; set; }

        /// <summary>
        /// 等待期结束时间 YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("wait_period_end")]
        public string WaitPeriodEnd { get; set; }
    }
}
