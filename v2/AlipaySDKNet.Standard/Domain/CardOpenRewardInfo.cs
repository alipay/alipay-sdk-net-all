using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardOpenRewardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardOpenRewardInfo : AopObject
    {
        /// <summary>
        /// LDP编码
        /// </summary>
        [XmlElement("ldp_code")]
        public string LdpCode { get; set; }

        /// <summary>
        /// 权限奖品列表
        /// </summary>
        [XmlArray("rewards")]
        [XmlArrayItem("activity_reward")]
        public List<ActivityReward> Rewards { get; set; }
    }
}
