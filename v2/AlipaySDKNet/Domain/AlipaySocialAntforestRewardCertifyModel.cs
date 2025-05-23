using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestRewardCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestRewardCertifyModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 奖品code
        /// </summary>
        [XmlElement("reward_code")]
        public string RewardCode { get; set; }

        /// <summary>
        /// 奖励发放的场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
