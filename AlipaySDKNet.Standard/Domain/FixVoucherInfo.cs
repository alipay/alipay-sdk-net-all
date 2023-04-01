using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FixVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FixVoucherInfo : AopObject
    {
        /// <summary>
        /// 面额，每张代金券可以抵扣的金额。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 门槛金额。该字段不填写，认为无门槛。
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
