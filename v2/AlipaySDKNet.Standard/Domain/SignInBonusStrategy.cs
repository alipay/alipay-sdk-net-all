using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignInBonusStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class SignInBonusStrategy : AopObject
    {
        /// <summary>
        /// 次数上限（发奖的最大签到次数）
        /// </summary>
        [XmlElement("max_time")]
        public long MaxTime { get; set; }

        /// <summary>
        /// 次数下限（发奖的最少签到次数）
        /// </summary>
        [XmlElement("min_time")]
        public long MinTime { get; set; }

        /// <summary>
        /// 奖品信息
        /// </summary>
        [XmlArray("prizes")]
        [XmlArrayItem("sign_in_prize_config")]
        public List<SignInPrizeConfig> Prizes { get; set; }

        /// <summary>
        /// 签到计数模式
        /// </summary>
        [XmlElement("signin_acc_type")]
        public string SigninAccType { get; set; }

        /// <summary>
        /// 发奖策略类型
        /// </summary>
        [XmlElement("strategy_type")]
        public string StrategyType { get; set; }
    }
}
