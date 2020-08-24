using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppletTaskPrizeVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppletTaskPrizeVO : AopObject
    {
        /// <summary>
        /// 奖品余额。
        /// </summary>
        [XmlElement("budget_amount")]
        public long BudgetAmount { get; set; }

        /// <summary>
        /// 奖品系数。
        /// </summary>
        [XmlElement("modulus")]
        public long Modulus { get; set; }

        /// <summary>
        /// 奖品id。
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称。
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品类型
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }
    }
}
