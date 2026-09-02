using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SplitInfoE Data Structure.
    /// </summary>
    [Serializable]
    public class SplitInfoE : AopObject
    {
        /// <summary>
        /// 原始期数/月
        /// </summary>
        [XmlElement("original_period")]
        public long OriginalPeriod { get; set; }

        /// <summary>
        /// 拆后其它金额，单位：元
        /// </summary>
        [XmlElement("split_other_amount")]
        public string SplitOtherAmount { get; set; }

        /// <summary>
        /// 拆分期数
        /// </summary>
        [XmlElement("split_period")]
        public long SplitPeriod { get; set; }

        /// <summary>
        /// 拆后租金金额，单位：元
        /// </summary>
        [XmlElement("split_rent_amount")]
        public string SplitRentAmount { get; set; }
    }
}
