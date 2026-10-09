using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSummary Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSummary : AopObject
    {
        /// <summary>
        /// 券已发放数量。
        /// </summary>
        [XmlElement("publish_count")]
        public long PublishCount { get; set; }

        /// <summary>
        /// 券已核销数量。
        /// </summary>
        [XmlElement("used_count")]
        public long UsedCount { get; set; }
    }
}
