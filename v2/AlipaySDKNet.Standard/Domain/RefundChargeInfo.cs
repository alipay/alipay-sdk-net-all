using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundChargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RefundChargeInfo : AopObject
    {
        /// <summary>
        /// 收单手续费trade，花呗分期手续hbfq，其他手续费charge
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 实退费用
        /// </summary>
        [XmlElement("refund_charge_fee")]
        public string RefundChargeFee { get; set; }

        /// <summary>
        /// 组合支付退费明细
        /// </summary>
        [XmlArray("refund_sub_fee_detail_list")]
        [XmlArrayItem("refund_sub_fee")]
        public List<RefundSubFee> RefundSubFeeDetailList { get; set; }

        /// <summary>
        /// 签约费率
        /// </summary>
        [XmlElement("switch_fee_rate")]
        public string SwitchFeeRate { get; set; }
    }
}
