using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RewardDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RewardDTO : AopObject
    {
        /// <summary>
        /// 奖励详情展示信息
        /// </summary>
        [XmlElement("reward_display_info")]
        public string RewardDisplayInfo { get; set; }

        /// <summary>
        /// 奖励编码，局部唯一，例如公益林详情接口下，每个公益林中的奖励code是唯一的
        /// </summary>
        [XmlElement("reward_id")]
        public string RewardId { get; set; }
    }
}
