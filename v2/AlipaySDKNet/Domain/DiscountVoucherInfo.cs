using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountVoucherInfo : AopObject
    {
        /// <summary>
        /// 封顶金额。
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 折扣率。
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 门槛金额。
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 优惠门槛信息
        /// </summary>
        [XmlElement("voucher_deduct_threshold_info")]
        public VoucherDeductThresholdInfo VoucherDeductThresholdInfo { get; set; }
    }
}
