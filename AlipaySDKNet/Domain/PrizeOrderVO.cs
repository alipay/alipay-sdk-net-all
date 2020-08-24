using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeOrderVO : AopObject
    {
        /// <summary>
        /// 发奖系数。
        /// </summary>
        [XmlElement("modulus")]
        public long Modulus { get; set; }

        /// <summary>
        /// 返奖奖品ID。
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称。
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 发奖单据ID
        /// </summary>
        [XmlElement("prize_order_id")]
        public string PrizeOrderId { get; set; }

        /// <summary>
        /// 返奖奖品类型。
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }
    }
}
