using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeBaseInfo : AopObject
    {
        /// <summary>
        /// 奖品固定金额
        /// </summary>
        [XmlElement("fix_price")]
        public string FixPrice { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("gmt_begin")]
        public string GmtBegin { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 系数,每次发放系数
        /// </summary>
        [XmlElement("modulus")]
        public long Modulus { get; set; }

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
        /// 奖品类型
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }
    }
}
