using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Vouchers Data Structure.
    /// </summary>
    [Serializable]
    public class Vouchers : AopObject
    {
        /// <summary>
        /// 优惠券可用面额(单位元)
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 营销卷的生效时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 优惠卷的到期时间
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 使用门槛(无门槛，则为空，存在使用门槛值，如满5减4，则使用门槛就是5.00，满10减1，则使用门槛就是10.00，单位元)
        /// </summary>
        [XmlElement("use_threshold")]
        public string UseThreshold { get; set; }

        /// <summary>
        /// 营销卷的ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 营销卷的名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }
    }
}
