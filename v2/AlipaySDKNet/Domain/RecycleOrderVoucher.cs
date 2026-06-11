using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleOrderVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleOrderVoucher : AopObject
    {
        /// <summary>
        /// 比例券会返回加价的比例，如5则代表加价5%，最高封顶金额为voucher_ceiling_amount
        /// </summary>
        [XmlElement("percentage")]
        public string Percentage { get; set; }

        /// <summary>
        /// 券封顶金额
        /// </summary>
        [XmlElement("voucher_ceiling_amount")]
        public string VoucherCeilingAmount { get; set; }

        /// <summary>
        /// 券过期时间
        /// </summary>
        [XmlElement("voucher_expire_time")]
        public string VoucherExpireTime { get; set; }

        /// <summary>
        /// 券门槛金额
        /// </summary>
        [XmlElement("voucher_floor_amount")]
        public string VoucherFloorAmount { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券领取时间
        /// </summary>
        [XmlElement("voucher_receive_time")]
        public string VoucherReceiveTime { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
