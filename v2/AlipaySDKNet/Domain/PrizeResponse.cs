using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeResponse : AopObject
    {
        /// <summary>
        /// 奖品预算
        /// </summary>
        [XmlElement("prize_budget")]
        public string PrizeBudget { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品价格、单位元、请使用正整数
        /// </summary>
        [XmlElement("prize_price")]
        public string PrizePrice { get; set; }
    }
}
