using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GameChallengePrizeVO Data Structure.
    /// </summary>
    [Serializable]
    public class GameChallengePrizeVO : AopObject
    {
        /// <summary>
        /// 副本活动对应的奖励数量
        /// </summary>
        [XmlElement("challenge_prize_amount")]
        public long ChallengePrizeAmount { get; set; }

        /// <summary>
        /// 副本活动奖品id，用于奖励结算时以及和支付宝系统交互使用的标识
        /// </summary>
        [XmlElement("challenge_prize_id")]
        public string ChallengePrizeId { get; set; }

        /// <summary>
        /// 副本活动对应奖励的等级，值越小，等级越高
        /// </summary>
        [XmlElement("challenge_prize_level")]
        public long ChallengePrizeLevel { get; set; }

        /// <summary>
        /// 副本活动对应的奖励名称
        /// </summary>
        [XmlElement("challenge_prize_name")]
        public string ChallengePrizeName { get; set; }

        /// <summary>
        /// 副本活动的奖励单位
        /// </summary>
        [XmlElement("challenge_prize_unit")]
        public string ChallengePrizeUnit { get; set; }
    }
}
