using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditRatePartialAuth Data Structure.
    /// </summary>
    [Serializable]
    public class CreditRatePartialAuth : AopObject
    {
        /// <summary>
        /// 信用等级范围最大值，范围是1-12，是闭区间
        /// </summary>
        [XmlElement("cr_max_rank")]
        public long CrMaxRank { get; set; }

        /// <summary>
        /// 信用等级范围最小值，范围是1-12，是闭区间
        /// </summary>
        [XmlElement("cr_min_rank")]
        public long CrMinRank { get; set; }
    }
}
