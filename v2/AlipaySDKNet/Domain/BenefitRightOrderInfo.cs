using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitRightOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitRightOrderInfo : AopObject
    {
        /// <summary>
        /// 外部奖品编号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 奖品配置
        /// </summary>
        [XmlElement("reward_config")]
        public BenefitRewardConfig RewardConfig { get; set; }

        /// <summary>
        /// 权益单业务状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券不可使用状态
        /// </summary>
        [XmlElement("unavailable_status")]
        public string UnavailableStatus { get; set; }

        /// <summary>
        /// 权益使用状态
        /// </summary>
        [XmlElement("use_status")]
        public string UseStatus { get; set; }
    }
}
