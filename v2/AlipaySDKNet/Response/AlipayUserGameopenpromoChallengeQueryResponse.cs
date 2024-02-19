using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGameopenpromoChallengeQueryResponse.
    /// </summary>
    public class AlipayUserGameopenpromoChallengeQueryResponse : AopResponse
    {
        /// <summary>
        /// 副本奖励列表, 用户所有能获得的奖励都在列表中
        /// </summary>
        [XmlArray("challenge_prize_list")]
        [XmlArrayItem("game_challenge_prize_v_o")]
        public List<GameChallengePrizeVO> ChallengePrizeList { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 参与副本活动需要消耗的福卡数量，可以直接对用户进行表达
        /// </summary>
        [XmlElement("fuka_cost")]
        public long FukaCost { get; set; }

        /// <summary>
        /// 用户福卡是否充足
        /// </summary>
        [XmlElement("fuka_enough")]
        public bool FukaEnough { get; set; }

        /// <summary>
        /// 使用该字段判断副本活动是否对用户可见，true表示可见
        /// </summary>
        [XmlElement("join_authority")]
        public bool JoinAuthority { get; set; }

        /// <summary>
        /// 用户最大参与次数，可用于对用户表达
        /// </summary>
        [XmlElement("join_max_limit")]
        public long JoinMaxLimit { get; set; }

        /// <summary>
        /// 用户已经参与的活动次数(已结算口径统计)，可以用来对客表达
        /// </summary>
        [XmlElement("join_times")]
        public long JoinTimes { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
