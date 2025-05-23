using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestRewardCertifyResponse.
    /// </summary>
    public class AlipaySocialAntforestRewardCertifyResponse : AopResponse
    {
        /// <summary>
        /// true-有对应奖励的领取资格 false-无资格
        /// </summary>
        [XmlElement("has_reward")]
        public bool HasReward { get; set; }
    }
}
