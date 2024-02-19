using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGameopenpromoChallengeSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGameopenpromoChallengeSettleModel : AopObject
    {
        /// <summary>
        /// 用户副本挑战实际的开始时间
        /// </summary>
        [XmlElement("challenge_begin_time")]
        public string ChallengeBeginTime { get; set; }

        /// <summary>
        /// 用户维度的参与挑战业务号，发奖会以此业务号做幂等
        /// </summary>
        [XmlElement("challenge_biz_no")]
        public string ChallengeBizNo { get; set; }

        /// <summary>
        /// 副本活动对应的奖励id, 从副本活动查询接口中获取
        /// </summary>
        [XmlElement("challenge_prize_id")]
        public string ChallengePrizeId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 结算时是否给用户发奖
        /// </summary>
        [XmlElement("reward_prize")]
        public bool RewardPrize { get; set; }

        /// <summary>
        /// 支付宝唯一用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
