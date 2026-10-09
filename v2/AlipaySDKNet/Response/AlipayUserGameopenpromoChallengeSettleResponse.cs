using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGameopenpromoChallengeSettleResponse.
    /// </summary>
    public class AlipayUserGameopenpromoChallengeSettleResponse : AopResponse
    {
        /// <summary>
        /// 结算的奖品信息,和副本查询接口的奖品保持一致
        /// </summary>
        [XmlElement("settle_prize_info")]
        public GameChallengePrizeVO SettlePrizeInfo { get; set; }

        /// <summary>
        /// 本次结算的当前状态
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }
    }
}
