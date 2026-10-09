using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPlaysigninConfigQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPlaysigninConfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户领奖方式
        /// </summary>
        [XmlElement("bonus_receive_type")]
        public string BonusReceiveType { get; set; }

        /// <summary>
        /// 签到发奖策略类型
        /// </summary>
        [XmlElement("bonus_send_strategy_type")]
        public string BonusSendStrategyType { get; set; }

        /// <summary>
        /// 签到发奖策略内容
        /// </summary>
        [XmlArray("bonus_strategies")]
        [XmlArrayItem("sign_in_bonus_strategy")]
        public List<SignInBonusStrategy> BonusStrategies { get; set; }

        /// <summary>
        /// 是否需报名
        /// </summary>
        [XmlElement("need_signup")]
        public bool NeedSignup { get; set; }

        /// <summary>
        /// 领奖过期表达式 相对时间示例: RELATIVE_30_NATURALDAYS 绝对时间示例: ABSOLUTELY_20210825224510
        /// </summary>
        [XmlElement("receive_time_expression")]
        public string ReceiveTimeExpression { get; set; }

        /// <summary>
        /// 签到时间维度（日月周）
        /// </summary>
        [XmlElement("signin_dimesion_type")]
        public string SigninDimesionType { get; set; }

        /// <summary>
        /// 签到次数上限（循环）
        /// </summary>
        [XmlElement("signin_upper_num")]
        public long SigninUpperNum { get; set; }

        /// <summary>
        /// 签到活动结束时间
        /// </summary>
        [XmlElement("signup_end_time")]
        public string SignupEndTime { get; set; }

        /// <summary>
        /// 签到开始时间
        /// </summary>
        [XmlElement("signup_start_time")]
        public string SignupStartTime { get; set; }
    }
}
