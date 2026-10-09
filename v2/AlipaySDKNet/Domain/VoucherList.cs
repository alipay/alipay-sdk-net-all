using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherList Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherList : AopObject
    {
        /// <summary>
        /// 券模版id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 券状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券金额
        /// </summary>
        [XmlElement("voucher_amount")]
        public string VoucherAmount { get; set; }

        /// <summary>
        /// 券的实例id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
