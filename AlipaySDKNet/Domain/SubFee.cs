using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubFee Data Structure.
    /// </summary>
    [Serializable]
    public class SubFee : AopObject
    {
        /// <summary>
        /// 实收费用
        /// </summary>
        [XmlElement("charge_fee")]
        public string ChargeFee { get; set; }

        /// <summary>
        /// 原始费用
        /// </summary>
        [XmlElement("original_charge_fee")]
        public string OriginalChargeFee { get; set; }

        /// <summary>
        /// 签约费率
        /// </summary>
        [XmlElement("switch_fee_rate")]
        public string SwitchFeeRate { get; set; }
    }
}
