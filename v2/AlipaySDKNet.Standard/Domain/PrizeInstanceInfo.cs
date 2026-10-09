using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeInstanceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeInstanceInfo : AopObject
    {
        /// <summary>
        /// 奖品的优惠面额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 奖品的优惠面额单位
        /// </summary>
        [XmlElement("discount_amount_unit")]
        public string DiscountAmountUnit { get; set; }

        /// <summary>
        /// 奖品的使用过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 奖品的使用门槛金额，默认单位：元
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 奖品的唯一标识
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品的类型
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }
    }
}
