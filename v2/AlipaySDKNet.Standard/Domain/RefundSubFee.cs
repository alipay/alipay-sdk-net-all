using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundSubFee Data Structure.
    /// </summary>
    [Serializable]
    public class RefundSubFee : AopObject
    {
        /// <summary>
        /// 实退费用
        /// </summary>
        [XmlElement("refund_charge_fee")]
        public string RefundChargeFee { get; set; }

        /// <summary>
        /// 签约费率
        /// </summary>
        [XmlElement("switch_fee_rate")]
        public string SwitchFeeRate { get; set; }
    }
}
