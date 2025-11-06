using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityPhase Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityPhase : AopObject
    {
        /// <summary>
        /// 0:未发放； 1:发放中； 2:已发放。
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
        /// 权限奖品列表
        /// </summary>
        [XmlArray("rewards")]
        [XmlArrayItem("activity_reward")]
        public List<ActivityReward> Rewards { get; set; }

        /// <summary>
        /// 目标计数
        /// </summary>
        [XmlElement("target_count")]
        public long TargetCount { get; set; }
    }
}
