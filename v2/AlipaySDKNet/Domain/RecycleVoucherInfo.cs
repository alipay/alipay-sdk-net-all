using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleVoucherInfo : AopObject
    {
        /// <summary>
        /// 券金额
        /// </summary>
        [XmlElement("voucher_amount")]
        public string VoucherAmount { get; set; }

        /// <summary>
        /// 券过期时间
        /// </summary>
        [XmlElement("voucher_expire_time")]
        public string VoucherExpireTime { get; set; }

        /// <summary>
        /// 券唯一ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券领取时间
        /// </summary>
        [XmlElement("voucher_receive_time")]
        public string VoucherReceiveTime { get; set; }

        /// <summary>
        /// PRE_RECEIVED 预领取 UNRECEIVED未领取 RECEIVED已领取 USED已核销 EXPIRED已过期
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
