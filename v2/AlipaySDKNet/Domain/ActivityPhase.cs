using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityPhase Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityPhase : AopObject
    {
        /// <summary>
        /// 0:无领取； 1:可领取； 2:已领取。
        /// </summary>
        [XmlElement("award_status")]
        public long AwardStatus { get; set; }

        /// <summary>
        /// 阶段序号
        /// </summary>
        [XmlElement("index")]
        public long Index { get; set; }

        /// <summary>
        /// LDP编码
        /// </summary>
        [XmlElement("ldp_code")]
        public string LdpCode { get; set; }

        /// <summary>
        /// 目标计数
        /// </summary>
        [XmlElement("target_count")]
        public long TargetCount { get; set; }
    }
}
