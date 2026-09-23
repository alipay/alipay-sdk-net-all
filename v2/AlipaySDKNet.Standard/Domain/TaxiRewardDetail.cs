using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxiRewardDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TaxiRewardDetail : AopObject
    {
        /// <summary>
        /// 发奖金额 单位：元
        /// </summary>
        [XmlElement("reward_amount")]
        public string RewardAmount { get; set; }

        /// <summary>
        /// 发奖时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("reward_time")]
        public string RewardTime { get; set; }
    }
}
