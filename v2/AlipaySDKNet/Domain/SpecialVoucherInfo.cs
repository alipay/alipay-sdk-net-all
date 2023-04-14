using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecialVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpecialVoucherInfo : AopObject
    {
        /// <summary>
        /// 门槛金额。
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 特价，即：原价-特价=优惠金额。
        /// </summary>
        [XmlElement("special_amount")]
        public string SpecialAmount { get; set; }

        /// <summary>
        /// 优惠门槛信息
        /// </summary>
        [XmlElement("voucher_deduct_threshold_info")]
        public VoucherDeductThresholdInfo VoucherDeductThresholdInfo { get; set; }
    }
}
