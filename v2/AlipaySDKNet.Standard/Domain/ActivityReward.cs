using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityReward Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityReward : AopObject
    {
        /// <summary>
        /// 权益奖品配置信息
        /// </summary>
        [XmlElement("reward_config")]
        public ActivityRewardConfig RewardConfig { get; set; }

        /// <summary>
        /// 券不可用原因，仅当 useStatus = disabled 才返回
        /// </summary>
        [XmlElement("unavailable_status")]
        public string UnavailableStatus { get; set; }

        /// <summary>
        /// 使用状态，仅当award_status== 2时才返回
        /// </summary>
        [XmlElement("use_status")]
        public string UseStatus { get; set; }
    }
}
