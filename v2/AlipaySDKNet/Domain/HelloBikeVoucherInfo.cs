using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HelloBikeVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HelloBikeVoucherInfo : AopObject
    {
        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 券价格
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 券剩余有效期
        /// </summary>
        [XmlElement("valid_time")]
        public long ValidTime { get; set; }

        /// <summary>
        /// 券描述
        /// </summary>
        [XmlElement("voucher_desc")]
        public string VoucherDesc { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券状态
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
