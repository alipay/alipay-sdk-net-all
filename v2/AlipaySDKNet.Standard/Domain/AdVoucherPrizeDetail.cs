using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdVoucherPrizeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AdVoucherPrizeDetail : AopObject
    {
        /// <summary>
        /// 推荐过期时间
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 发奖系数(一次可能发多个奖品，该字段指明一次发奖个数)
        /// </summary>
        [XmlElement("modulus")]
        public long Modulus { get; set; }

        /// <summary>
        /// 外部奖品ID
        /// </summary>
        [XmlElement("out_prize_id")]
        public string OutPrizeId { get; set; }

        /// <summary>
        /// 奖品父发奖单据id
        /// </summary>
        [XmlElement("parent_order_id")]
        public string ParentOrderId { get; set; }

        /// <summary>
        /// 奖品金额,单位元
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

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
        /// 奖品子类型
        /// </summary>
        [XmlElement("prize_sub_type")]
        public string PrizeSubType { get; set; }

        /// <summary>
        /// 奖品类型
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 发奖记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 发奖单据ID
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }

        /// <summary>
        /// 发奖时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 奖品状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 核销时间
        /// </summary>
        [XmlElement("use_time")]
        public string UseTime { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
