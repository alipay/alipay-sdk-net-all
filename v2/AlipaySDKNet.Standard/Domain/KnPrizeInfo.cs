using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KnPrizeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KnPrizeInfo : AopObject
    {
        /// <summary>
        /// 支付宝营销海豚奖品生效时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_begin")]
        public string GmtBegin { get; set; }

        /// <summary>
        /// 支付宝营销海豚奖品结束时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 支付宝营销海豚奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 支付宝营销海豚奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 支付宝营销海豚奖品子类型
        /// </summary>
        [XmlElement("prize_sub_type")]
        public string PrizeSubType { get; set; }

        /// <summary>
        /// 支付宝营销海豚奖品类型
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }
    }
}
