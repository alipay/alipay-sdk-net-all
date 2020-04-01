using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IgAuthQuota Data Structure.
    /// </summary>
    [Serializable]
    public class IgAuthQuota : AopObject
    {
        /// <summary>
        /// 份额数量
        /// </summary>
        [XmlElement("quota_count")]
        public long QuotaCount { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        [XmlElement("range_type")]
        public string RangeType { get; set; }
    }
}
