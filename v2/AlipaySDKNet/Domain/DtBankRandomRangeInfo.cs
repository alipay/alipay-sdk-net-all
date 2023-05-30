using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankRandomRangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankRandomRangeInfo : AopObject
    {
        /// <summary>
        /// 随机区间上限，单位分
        /// </summary>
        [XmlElement("max_amount")]
        public long MaxAmount { get; set; }

        /// <summary>
        /// 随机区间下限，单位分
        /// </summary>
        [XmlElement("min_amount")]
        public long MinAmount { get; set; }

        /// <summary>
        /// 随机区间占比，例如20表示此区间占比20%，取值范围(0, 100]
        /// </summary>
        [XmlElement("percentage")]
        public long Percentage { get; set; }
    }
}
