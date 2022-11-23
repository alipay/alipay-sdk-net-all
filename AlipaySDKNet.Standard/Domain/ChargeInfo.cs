using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeInfo : AopObject
    {
        /// <summary>
        /// 实收费用
        /// </summary>
        [XmlElement("charge_fee")]
        public string ChargeFee { get; set; }

        /// <summary>
        /// 收单手续费trade，花呗分期手续hbfq，其他手续费charge
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 是否合约指定收费账号出资，值为"Y"或"N"
        /// </summary>
        [XmlElement("is_rating_on_switch")]
        public string IsRatingOnSwitch { get; set; }

        /// <summary>
        /// 是否收款账号出资，值为"Y"或"N"
        /// </summary>
        [XmlElement("is_rating_on_trade_receiver")]
        public string IsRatingOnTradeReceiver { get; set; }

        /// <summary>
        /// 原始费用
        /// </summary>
        [XmlElement("original_charge_fee")]
        public string OriginalChargeFee { get; set; }

        /// <summary>
        /// 组合支付收费明细
        /// </summary>
        [XmlArray("sub_fee_detail_list")]
        [XmlArrayItem("sub_fee")]
        public List<SubFee> SubFeeDetailList { get; set; }

        /// <summary>
        /// 签约费率
        /// </summary>
        [XmlElement("switch_fee_rate")]
        public string SwitchFeeRate { get; set; }
    }
}
