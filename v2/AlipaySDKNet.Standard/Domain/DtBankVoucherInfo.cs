using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankVoucherInfo : AopObject
    {
        /// <summary>
        /// 发放限制信息
        /// </summary>
        [XmlElement("activity_send_control_config_info")]
        public DtbankActivitySendControlConfigInfo ActivitySendControlConfigInfo { get; set; }

        /// <summary>
        /// 是否允许拆分使用 定额红包时： true: 可以拆分使用 false：不可以拆分使用 为null时：历史活动，不可以拆分使用 非立减：空字段
        /// </summary>
        [XmlElement("allow_voucher_split")]
        public bool AllowVoucherSplit { get; set; }

        /// <summary>
        /// 红包有效时间
        /// </summary>
        [XmlElement("coupon_available_time")]
        public DtBankCouponAvailableTime CouponAvailableTime { get; set; }

        /// <summary>
        /// 红包使用说明文案
        /// </summary>
        [XmlArray("coupon_instruction_list")]
        [XmlArrayItem("string")]
        public List<string> CouponInstructionList { get; set; }

        /// <summary>
        /// 消费门槛 字段取值： 有门槛，门槛金额XX元  or  零门槛
        /// </summary>
        [XmlElement("threshold_text")]
        public string ThresholdText { get; set; }
    }
}
